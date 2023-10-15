using System;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using WowServer.Server;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace WowServer
{
    public partial class MainConfig : Form
    {
        static int second = 0;
        public MainConfig()
        {
            InitializeComponent();

            //初始化所有按钮
            DialogInit();

            // 订阅事件，当数据更新时触发 BindDataToListView 方法
            GlobalData.Instance.DataUpdated += BindDataToListView;

            //var socket = SocketMgr.Instance;
            //socket.StartServer();
        }

        private void DialogInit()
        {
            //StartBtn.Enabled = false;
            StopBtn.Enabled = false;

            //加载配置信息到小部件上
            SetDialogData();
        }
       
        private async void StartButton(object sender, EventArgs e)
        {
            try
            {
                Utils utils = new Utils();
                int httpPort = int.Parse(HttpPort.Text);
                if (httpPort > 65535)
                {
                    MessageBox.Show("端口不能大于65535");
                    return;
                }
                //端口是否被占用
                if (utils.IsPortInUse(httpPort))
                {
                    MessageBox.Show("http端口已被使用");
                    return;
                }
                int socketPort = int.Parse(ServerPort.Text);
                if (socketPort > 65535)
                {
                    MessageBox.Show("端口不能大于65535");
                    return;
                }
                //端口是否被占用
                if (utils.IsPortInUse(socketPort))
                {
                    MessageBox.Show("服务器端口已被使用");
                    return;
                }
                if(httpPort == socketPort)
                {
                    MessageBox.Show("两个端口不能相同");
                    return;
                }
                //启动go进程完成
                bool startOk = await StartExternalExe();
                if (startOk)
                {
                    //设置Socket服务器配置信息
                    bool isOk = await SetServerCfg();
                    if (isOk)
                    {
                        StartBtn.Enabled = false;
                        StopBtn.Enabled = true;
                        // 连接 Socket 服务器
                        var socket = SocketMgr.Instance;
                        socket.StartServer();
                        //// 反序列化 JSON 内容为 ConfigJson 对象
                        //var config = JsonObj.Instance;

                        //Http httpInstance = Http.Instance;
                        //// 连接 HTTP 服务器
                        //bool httpConnected = await httpInstance.ConnectHttp(config.Host, config.HttpPort);

                        //if (httpConnected)
                        //{
                        //    // 发送 HTTP GET 请求, 启动socket服务.
                        //    bool httpGetResult = await httpInstance.SendHttpGetStartRequest();
                        //    if (httpGetResult)
                        //    {
                        //        StartBtn.Enabled = false;
                        //        StopBtn.Enabled = true;
                        //        // 连接 Socket 服务器
                        //        var socket = SocketMgr.Instance;
                        //        socket.StartServer();
                        //    }
                        //}
                        //else
                        //{
                        //    MessageBox.Show("无法连接到HTTP服务器");
                        //    return;
                        //}
                    }
                }
            }
            catch (FormatException)
            {
                // 转换失败，文本框中的内容无法解析为整数
                MessageBox.Show("请务必输入数字,建议端口号在30000起步。");
                return;
            }
        }

        private Task<bool> StartExternalExe()
        {
            try
            {
                string exePath = "server.exe"; // 替换为你的 EXE 文件的路径
                Process.Start(exePath);
                return Task.FromResult(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("启动服务程序时发生错误：" + ex.Message);
                return Task.FromResult(false);
            }
        }

        //当关闭winform进程时
        private async void MainConfig_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            //此处应该告知go服务端也关闭
            Http httpInstance = Http.Instance;
            await httpInstance.SendHttpGetStopRequest();
        }

        //加载配置信息到小部件上
        public void SetDialogData()
        {
            try
            {
                // 反序列化 JSON 内容为 ConfigJson 对象
                var config = JsonObj.Instance;
                dev_switch.Checked = config.Develop; // 开发者模式
                ServerIp.Text = config.Host; //socket服务器ip
                ServerPort.Text = config.TcpPort.ToString(); //socket端口
                ServerName.Text = config.Name; //服务器名称
                MaxConn.Text = config.MaxConn.ToString(); //最大连接数量
                ServerVersion.Text = config.Version; //版本名称
                PackageSize.Text = config.MaxPackageSize.ToString(); //数据包大小
                WorkerPoolSize.Text = config.WorkerPoolSize.ToString(); //协程池大小
                HttpPort.Text = config.HttpPort.ToString();
                website.Text = config.WebSite;
                paywebsite.Text = config.PayWebSite;
                DbChara.Text = "";
                string connectionString = config.AuthDsn;
                BanSql.Checked = config.BanSql;
                // 使用 Split 方法来拆分连接字符串
                string[] parts = connectionString.Split('@');

                if (parts.Length == 2)
                {
                    string userInfo = parts[0];
                    string databaseInfo = parts[1];

                    // 提取用户名和密码
                    string[] userInfoParts = userInfo.Split(':');
                    if (userInfoParts.Length == 2)
                    {
                        DbUser.Text = userInfoParts[0];
                        DbPwd.Text = userInfoParts[1];
                    }

                    // 提取数据库相关信息
                    string[] dbInfoParts = databaseInfo.Split('/');
                    if (dbInfoParts.Length == 2)
                    {
                        string serverInfo = dbInfoParts[0];
                        string dbNameAndOptions = dbInfoParts[1];

                        //取数据库地址和端口号
                        string[] serverInfoParts = serverInfo.Split('(');
                        if (serverInfoParts.Length == 2)
                        {
                            // 获取服务器地址和端口号部分，例如：localhost:3306
                            string serverAddressAndPort = serverInfoParts[1].Trim(')');

                            // 分割服务器地址和端口号
                            string[] serverAddressAndPortParts = serverAddressAndPort.Split(':');
                            if (serverAddressAndPortParts.Length == 2)
                            {
                                string serverAddress = serverAddressAndPortParts[0];
                                string serverPort = serverAddressAndPortParts[1];

                                // 将值分配给相应的控件或变量
                                DbAddr.Text = serverAddress;
                                DbPort.Text = serverPort;
                            }
                        }
                        // 提取数据库名和其他选项
                        string[] dbNameAndOptionsParts = dbNameAndOptions.Split('?');
                        if (dbNameAndOptionsParts.Length == 2)
                        {
                            DbAuth.Text = dbNameAndOptionsParts[0];
                        }
                    }
                }


            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("没有找到配置文件，请查看conf目录下是否有.json文件。");
            }
            catch (Exception ex)
            {
                // 处理其他可能的异常
                MessageBox.Show("发生了异常：" + ex.Message);
            }
        }


        //设置服务器配置信息
        private Task<bool> SetServerCfg()
        {
            try
            {
                var config = JsonObj.Instance;
                config.Develop = dev_switch.Checked; // 开发者模式
                config.Host = ServerIp.Text; //socket服务器ip
                config.TcpPort = int.Parse(ServerPort.Text); //socket端口
                config.Name = ServerName.Text; //服务器名称
                config.MaxConn = int.Parse(MaxConn.Text); //最大连接数量
                config.Version = ServerVersion.Text; //版本名称
                config.MaxPackageSize = int.Parse(PackageSize.Text); //数据包大小
                config.WorkerPoolSize= int.Parse(WorkerPoolSize.Text); //协程池大小
                config.HttpPort = int.Parse(HttpPort.Text); //http服务器端口
                config.WebSite = website.Text;
                config.PayWebSite = paywebsite.Text;
                //一些值得转换和组合
                string utf8 = Ismb4.Checked ? "utf8mb4" : "utf8";
                string dbUser = DbUser.Text; // 数据库用户名
                string dbPwd = DbPwd.Text; // 数据库密码
                string dbPort = DbPort.Text; //数据库端口
                string dbAddr = DbAddr.Text; // 数据库ip地址
                string dbAuth = DbAuth.Text; // 账号库名称
                string DbCh = DbChara.Text; // 角色库名称
                config.BanSql = BanSql.Checked;
                // 构建连接字符串
                string AuthDB = $"{dbUser}:{dbPwd}@tcp({dbAddr}:{dbPort})/{dbAuth}?charset={utf8}&parseTime=True&loc=Local";
                string CharaDsn = $"{dbUser}:{dbPwd}@tcp({dbAddr}:{dbPort})/{DbCh}?charset={utf8}&parseTime=True&loc=Local";
                config.AuthDsn = AuthDB;
                config.CharaDsn = CharaDsn;
                

                // 将修改后的 config 对象序列化为 JSON 字符串
                string jsonString = JsonSerializer.Serialize(config);

                // 保存 JSON 字符串回文件（如果需要的话）
                File.WriteAllText("./conf/config.json", jsonString);
                SetStatus(false);
                return Task.FromResult(true);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("没有找到配置文件，请查看conf目录下是否有.json文件。");
                return Task.FromResult(false);
            }
            catch (Exception ex)
            {
                // 处理其他可能的异常
                MessageBox.Show("发生了异常：" + ex.Message);
                return Task.FromResult(false);
            }
        }

        //当停止服务时
        private async void StopBtn_Click(object sender, EventArgs e)
        {
            var socket = SocketMgr.Instance;
            socket.StopServer();
            //清空所有列表
            GlobalData.Instance.ClearnAll();
            Http httpInstance = Http.Instance;
            //1. 发送get请求,停止服务,关闭进程
            await httpInstance.SendHttpGetStopRequest();
            //2. 启动服务按钮开启.
            StartBtn.Enabled = true;
            //3. 停止服务按钮关闭
            StopBtn.Enabled = false;
            SetStatus(true);
        }

        // 绑定数据到 ListView
        public void BindDataToListView()
        {
            if (ClientList.InvokeRequired)
            {
                ClientList.Invoke((MethodInvoker)delegate
                {
                    // 在UI线程上执行更新操作
                    BindDataToListView();
                });
            }
            else
            {
                ClientList.Items.Clear();

                foreach (var clientInfo in GlobalData.Instance.ClientList)
                {
                    {
                        //if (clientInfo.ConnId != 0)
                        {
                            ListViewItem item = new ListViewItem(clientInfo.ConnId.ToString());
                            //item.SubItems.Add(clientInfo.ConnId.ToString());
                            item.SubItems.Add(clientInfo.IpAddr);
                            item.SubItems.Add(clientInfo.MacAddr);
                            item.SubItems.Add(clientInfo.OsVersion);
                            ClientList.Items.Add(item);
                        }
                    }
                }
            }
            ConnCount.Text = ClientList.Items.Count.ToString();
        }

        private void ClientList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

            //在此处设断点，发现点击不同的Item后，此事件居然执行了2次 //第一次是取消当前Item选中状态，导致整个ListView的SelectedIndices变为0
            //第二次才将新选中的Item设置为选中状态，SelectedIndices变为1
            //如果不加listview.SelectedIndices.Count>0判断，将导致获取listview.Items[]索引超界的异常

            // 判断是否取消选中
            //if (e.IsSelected)
            //{
            //    string ConnId = e.Item.Text; // 第1列
            //    string Ip = e.Item.SubItems[1].Text; // 第2列
            //    string Mac = e.Item.SubItems[2].Text; // 第3列
            //    string Os = e.Item.SubItems[3].Text; // 第4列
            //}
        }


        //踢人
        private void MenuCloseConn_Click(object sender, EventArgs e)
        {
            if (ClientList.SelectedItems.Count > 0)
            {
                string ConnId = ClientList.SelectedItems[0].Text; // 第1列
                string macAddr = ClientList.SelectedItems[0].SubItems[2].Text; // 第3列
                var socket = SocketMgr.Instance;
                socket.CloseClient(ConnId, macAddr);
            }
        }

        //封禁
        private void MenuBanClient_Click(object sender, EventArgs e)
        {
            
        }

        //进行封禁
        private void BanTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ClientList.SelectedItems.Count > 0)
            {
                string connId = ClientList.SelectedItems[0].Text; // 第1列
                string ipAddr = ClientList.SelectedItems[0].SubItems[1].Text; // 第2列
                string macAddr = ClientList.SelectedItems[0].SubItems[2].Text; // 第3列

                if (e.KeyChar == (char)Keys.Enter)
                {
                    string inputText = BanTime.Text; // 获取输入的文本

                    bool isNumeric = int.TryParse(inputText, out int number);

                    if (isNumeric && number > 0)
                    {
                        var socket = SocketMgr.Instance;
                        socket.BanClient(connId, ipAddr, macAddr, number.ToString());
                        contextMenuStrip1.Hide();
                    }
                    else
                    {
                        // 输入的值不是一个整数
                        MessageBox.Show("输入的值不是一个正整数。");

                    }
                }
            }

        }

        private void LoadData()
        {
            // 获取当前目录下的ban.txt文件的完整路径
            string filePath = Helper.BanPath;

            // 检查文件是否存在
            if (File.Exists(filePath))
            {
                // 读取文件的所有行
                string[] lines = File.ReadAllLines(filePath);

                // 遍历每一行，并将内容添加到ComboBox
                foreach (string line in lines)
                {
                    // 按照#分割行，并添加每个部分到ComboBox
                    string[] parts = line.Split('#');
                    if (parts.Length == 3)
                    {
                        long unixTimestamp = long.Parse(parts[2]);

                        DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(unixTimestamp);

                        // 设置所需的目标时区
                        TimeZoneInfo chinaTimeZone = TimeZoneInfo.FindSystemTimeZoneById("China Standard Time");

                        // 将时间从 UTC 转换为目标时区
                        DateTime dateTimeInTargetTimeZone = TimeZoneInfo.ConvertTimeFromUtc(dateTimeOffset.DateTime, chinaTimeZone);

                        // 格式化时间
                        string formattedTime = dateTimeInTargetTimeZone.ToString("yyyy-MM-dd-HH:mm:ss");


                        string comboItem = $"{parts[0]}  {parts[1]}  解封时间:{formattedTime}";
                        BanList.Items.Add(comboItem);
                    }
                }
            }
            else
            {
                // 如果文件不存在，显示错误消息
                MessageBox.Show("文件 'ban.txt' 不存在。");
            }
        }

        private void BanList_DropDown(object sender, EventArgs e)
        {
            // 当ComboBox的下拉列表被打开时，加载数据
            BanList.Items.Clear(); // 清空ComboBox中的项
            LoadData(); // 加载数据到ComboBox
        }


        private void BanList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 当用户选择ComboBox中的项时，执行操作
            if (BanList.SelectedItem != null)
                selectedComboBoxItem = BanList.SelectedItem;
        }



        //解除ban
        private object selectedComboBoxItem = ""; // 用于存储已选中的项
        private void RemoveBan_MouseClick(object sender, MouseEventArgs e)
        {
            var res = selectedComboBoxItem;
            if (res.ToString() == "")
            {
                MessageBox.Show("请重新选择需要解封的数据");
                return;
            }
            string selectedText = selectedComboBoxItem.ToString();
            string[] fields = selectedText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (fields.Length == 3)
            {
                string ip = fields[0];
                string mac = fields[1];

                // 发包
                var socket = SocketMgr.Instance;
                socket.RemoveBanClient(ip, mac);
                // 从ComboBox的Items集合中移除选定的项
                BanList.Items.Remove(selectedComboBoxItem);

                // 刷新ComboBox的显示
                BanList.Refresh();
            }
        }

        //服务器运行时间
        private void timer1_Tick(object sender, EventArgs e)
        {
            second += 1;
            SerRunTIme.Text = (second % (3600 * 24)) / 3600 + "时" + (second % 3600) / 60 + "分" + (second % 60) + "秒";
        }

        //网关剩余过期时间
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Helper.remainTime > 0)
            {
                long totalSeconds = Helper.remainTime;

                long days = totalSeconds / (3600 * 24);
                long hours = (totalSeconds % (3600 * 24)) / 3600;
                long minutes = (totalSeconds % 3600) / 60;
                long seconds = totalSeconds % 60;

                LabRemainTime.Text = $"{days}天 {hours}时 {minutes}分 {seconds}秒";
            }
        }

        private void SetStatus(bool s)
        {
            dev_switch.Enabled=s; // 开发者模式
            ServerIp.Enabled = s; //socket服务器ip
            ServerPort.Enabled = s; //socket端口
            ServerName.Enabled = s; //服务器名称
            MaxConn.Enabled = s; //最大连接数量
            ServerVersion.Enabled = s; //版本名称
            PackageSize.Enabled = s; //数据包大小
            WorkerPoolSize.Enabled = s; //协程池大小
            HttpPort.Enabled = s; //http端口
            BanSql.Enabled = s; //是否ban数据库check
            Ismb4.Enabled = s; //是否启用utf8mb4
            DbUser.Enabled = s; // 数据库用户名
            DbPwd.Enabled = s; // 数据库密码
            DbPort.Enabled = s; // 数据库端口
            DbAddr.Enabled = s; // 数据库ip地址
            DbAuth.Enabled = s; // 账号库名称
            DbChara.Enabled = s; //角色库名称
            website.Enabled = s;
            paywebsite.Enabled = s;
        }
    }
}

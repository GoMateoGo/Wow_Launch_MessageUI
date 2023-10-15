namespace WowServer
{
    partial class MainConfig
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainConfig));
            this.StartBtn = new System.Windows.Forms.Button();
            this.StopBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dev_switch = new System.Windows.Forms.CheckBox();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.ServerName = new System.Windows.Forms.TextBox();
            this.ServerPort = new System.Windows.Forms.TextBox();
            this.ServerIp = new System.Windows.Forms.TextBox();
            this.MaxConn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ServerVersion = new System.Windows.Forms.TextBox();
            this.PackageSize = new System.Windows.Forms.TextBox();
            this.WorkerPoolSize = new System.Windows.Forms.TextBox();
            this.DbAddr = new System.Windows.Forms.TextBox();
            this.DbUser = new System.Windows.Forms.TextBox();
            this.DbPwd = new System.Windows.Forms.TextBox();
            this.Ismb4 = new System.Windows.Forms.CheckBox();
            this.HttpPort = new System.Windows.Forms.TextBox();
            this.BanSql = new System.Windows.Forms.CheckBox();
            this.DbPort = new System.Windows.Forms.TextBox();
            this._ServerName = new System.Windows.Forms.Label();
            this._ServerPort = new System.Windows.Forms.Label();
            this._ServerIp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.DbAuth = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DbChara = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ClientList = new System.Windows.Forms.ListView();
            this.ClientId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClientIp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClientMac = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClientOs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuCloseConn = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBanClient = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.BanTime = new System.Windows.Forms.ToolStripTextBox();
            this.BanList = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.RemoveBan = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.ConnCount = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.SerRunTIme = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LabRemainTime = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label18 = new System.Windows.Forms.Label();
            this.website = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.paywebsite = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartBtn
            // 
            this.StartBtn.ForeColor = System.Drawing.Color.DarkGreen;
            this.StartBtn.Location = new System.Drawing.Point(22, 693);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(92, 32);
            this.StartBtn.TabIndex = 0;
            this.StartBtn.Text = "启动服务";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartButton);
            // 
            // StopBtn
            // 
            this.StopBtn.ForeColor = System.Drawing.Color.Red;
            this.StopBtn.Location = new System.Drawing.Point(135, 693);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(98, 32);
            this.StopBtn.TabIndex = 1;
            this.StopBtn.Text = "停止服务";
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(4, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "开发者模式";
            // 
            // dev_switch
            // 
            this.dev_switch.AutoSize = true;
            this.dev_switch.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dev_switch.Location = new System.Drawing.Point(113, 29);
            this.dev_switch.Name = "dev_switch";
            this.dev_switch.Size = new System.Drawing.Size(51, 21);
            this.dev_switch.TabIndex = 3;
            this.dev_switch.Text = "开启";
            this.tooltip.SetToolTip(this.dev_switch, "开启后控制台显示一些日志信息.");
            this.dev_switch.UseVisualStyleBackColor = true;
            // 
            // tooltip
            // 
            this.tooltip.AutoPopDelay = 5000;
            this.tooltip.InitialDelay = 10;
            this.tooltip.IsBalloon = true;
            this.tooltip.ReshowDelay = 100;
            this.tooltip.ShowAlways = true;
            this.tooltip.Tag = "";
            this.tooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tooltip.ToolTipTitle = "提示";
            // 
            // ServerName
            // 
            this.ServerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ServerName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ServerName.Location = new System.Drawing.Point(91, 56);
            this.ServerName.Name = "ServerName";
            this.ServerName.Size = new System.Drawing.Size(108, 23);
            this.ServerName.TabIndex = 5;
            this.tooltip.SetToolTip(this.ServerName, "服务器名称");
            // 
            // ServerPort
            // 
            this.ServerPort.BackColor = System.Drawing.Color.White;
            this.ServerPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ServerPort.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ServerPort.Location = new System.Drawing.Point(91, 124);
            this.ServerPort.Name = "ServerPort";
            this.ServerPort.Size = new System.Drawing.Size(108, 23);
            this.ServerPort.TabIndex = 6;
            this.tooltip.SetToolTip(this.ServerPort, "该端口号和刚才的http端口号要求不同");
            // 
            // ServerIp
            // 
            this.ServerIp.BackColor = System.Drawing.Color.White;
            this.ServerIp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ServerIp.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ServerIp.Location = new System.Drawing.Point(91, 90);
            this.ServerIp.Name = "ServerIp";
            this.ServerIp.Size = new System.Drawing.Size(108, 23);
            this.ServerIp.TabIndex = 8;
            this.tooltip.SetToolTip(this.ServerIp, "保持和服务器的ip地址一样");
            // 
            // MaxConn
            // 
            this.MaxConn.BackColor = System.Drawing.Color.White;
            this.MaxConn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaxConn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MaxConn.Location = new System.Drawing.Point(91, 190);
            this.MaxConn.Name = "MaxConn";
            this.MaxConn.Size = new System.Drawing.Size(108, 23);
            this.MaxConn.TabIndex = 10;
            this.tooltip.SetToolTip(this.MaxConn, "多少玩家可以链接到服务器");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(18, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "当前版本";
            this.tooltip.SetToolTip(this.label3, "当前游戏版本,如果是335,就输入:2,243就输入:2");
            // 
            // ServerVersion
            // 
            this.ServerVersion.BackColor = System.Drawing.Color.White;
            this.ServerVersion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ServerVersion.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ServerVersion.Location = new System.Drawing.Point(91, 297);
            this.ServerVersion.Name = "ServerVersion";
            this.ServerVersion.Size = new System.Drawing.Size(108, 23);
            this.ServerVersion.TabIndex = 12;
            this.ServerVersion.Text = "3";
            this.tooltip.SetToolTip(this.ServerVersion, "3.3.5就输入3  2.43就输入2 以此类推");
            // 
            // PackageSize
            // 
            this.PackageSize.BackColor = System.Drawing.Color.White;
            this.PackageSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PackageSize.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PackageSize.Location = new System.Drawing.Point(91, 226);
            this.PackageSize.Name = "PackageSize";
            this.PackageSize.Size = new System.Drawing.Size(108, 23);
            this.PackageSize.TabIndex = 14;
            this.PackageSize.Text = "4096";
            this.tooltip.SetToolTip(this.PackageSize, "一般情况下保持默认即可");
            // 
            // WorkerPoolSize
            // 
            this.WorkerPoolSize.BackColor = System.Drawing.Color.White;
            this.WorkerPoolSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WorkerPoolSize.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.WorkerPoolSize.Location = new System.Drawing.Point(91, 263);
            this.WorkerPoolSize.Name = "WorkerPoolSize";
            this.WorkerPoolSize.Size = new System.Drawing.Size(108, 23);
            this.WorkerPoolSize.TabIndex = 16;
            this.WorkerPoolSize.Text = "10";
            this.tooltip.SetToolTip(this.WorkerPoolSize, "一般不用修改,默认值10可以至少可以快速响应1K玩家链接,根据服务器带宽和玩家数调整.");
            // 
            // DbAddr
            // 
            this.DbAddr.BackColor = System.Drawing.Color.White;
            this.DbAddr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DbAddr.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DbAddr.Location = new System.Drawing.Point(91, 55);
            this.DbAddr.Name = "DbAddr";
            this.DbAddr.Size = new System.Drawing.Size(108, 23);
            this.DbAddr.TabIndex = 18;
            this.DbAddr.Text = "localhost";
            this.tooltip.SetToolTip(this.DbAddr, "没有远程数据库就不需要改动");
            // 
            // DbUser
            // 
            this.DbUser.BackColor = System.Drawing.Color.White;
            this.DbUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DbUser.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DbUser.Location = new System.Drawing.Point(91, 96);
            this.DbUser.Name = "DbUser";
            this.DbUser.Size = new System.Drawing.Size(108, 23);
            this.DbUser.TabIndex = 22;
            this.DbUser.Text = "root";
            this.tooltip.SetToolTip(this.DbUser, "根据自己的用户名填写,建议创建新的用户并设置只写和只查询权限");
            // 
            // DbPwd
            // 
            this.DbPwd.BackColor = System.Drawing.Color.White;
            this.DbPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DbPwd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DbPwd.Location = new System.Drawing.Point(91, 135);
            this.DbPwd.Name = "DbPwd";
            this.DbPwd.Size = new System.Drawing.Size(108, 23);
            this.DbPwd.TabIndex = 24;
            this.DbPwd.Text = "root";
            this.tooltip.SetToolTip(this.DbPwd, "根据自己的用户名填写,建议创建新的用户并设置只写和只查询权限");
            // 
            // Ismb4
            // 
            this.Ismb4.AutoSize = true;
            this.Ismb4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Ismb4.Location = new System.Drawing.Point(115, 28);
            this.Ismb4.Name = "Ismb4";
            this.Ismb4.Size = new System.Drawing.Size(39, 21);
            this.Ismb4.TabIndex = 19;
            this.Ismb4.Text = "是";
            this.tooltip.SetToolTip(this.Ismb4, "请自行查询数据库类型,可以百度搜索:查看数据库字符集");
            this.Ismb4.UseVisualStyleBackColor = true;
            // 
            // HttpPort
            // 
            this.HttpPort.BackColor = System.Drawing.Color.White;
            this.HttpPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HttpPort.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HttpPort.Location = new System.Drawing.Point(91, 156);
            this.HttpPort.Name = "HttpPort";
            this.HttpPort.Size = new System.Drawing.Size(108, 23);
            this.HttpPort.TabIndex = 18;
            this.tooltip.SetToolTip(this.HttpPort, "该端口用于下载服务,不要和服务到期端口相同");
            // 
            // BanSql
            // 
            this.BanSql.AutoSize = true;
            this.BanSql.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BanSql.Location = new System.Drawing.Point(544, 239);
            this.BanSql.Name = "BanSql";
            this.BanSql.Size = new System.Drawing.Size(39, 21);
            this.BanSql.TabIndex = 40;
            this.BanSql.Text = "是";
            this.tooltip.SetToolTip(this.BanSql, "同时在游戏内禁用被ban的ip地址,需要连接数据库");
            this.BanSql.UseVisualStyleBackColor = true;
            // 
            // DbPort
            // 
            this.DbPort.BackColor = System.Drawing.Color.White;
            this.DbPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DbPort.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DbPort.Location = new System.Drawing.Point(91, 174);
            this.DbPort.Name = "DbPort";
            this.DbPort.Size = new System.Drawing.Size(108, 23);
            this.DbPort.TabIndex = 26;
            this.DbPort.Text = "3306";
            // 
            // _ServerName
            // 
            this._ServerName.AutoSize = true;
            this._ServerName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._ServerName.Location = new System.Drawing.Point(4, 56);
            this._ServerName.Name = "_ServerName";
            this._ServerName.Size = new System.Drawing.Size(68, 17);
            this._ServerName.TabIndex = 4;
            this._ServerName.Text = "服务器名称";
            // 
            // _ServerPort
            // 
            this._ServerPort.AutoSize = true;
            this._ServerPort.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._ServerPort.Location = new System.Drawing.Point(4, 124);
            this._ServerPort.Name = "_ServerPort";
            this._ServerPort.Size = new System.Drawing.Size(68, 17);
            this._ServerPort.TabIndex = 7;
            this._ServerPort.Text = "服务器端口";
            // 
            // _ServerIp
            // 
            this._ServerIp.AutoSize = true;
            this._ServerIp.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._ServerIp.Location = new System.Drawing.Point(4, 90);
            this._ServerIp.Name = "_ServerIp";
            this._ServerIp.Size = new System.Drawing.Size(68, 17);
            this._ServerIp.TabIndex = 9;
            this._ServerIp.Text = "服务器地址";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(4, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "最大连接数";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(4, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "数据包大小";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(4, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "协程池大小";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(6, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "数据库地址";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.HttpPort);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.dev_switch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this._ServerName);
            this.groupBox1.Controls.Add(this.ServerName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ServerPort);
            this.groupBox1.Controls.Add(this.WorkerPoolSize);
            this.groupBox1.Controls.Add(this._ServerPort);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ServerIp);
            this.groupBox1.Controls.Add(this.PackageSize);
            this.groupBox1.Controls.Add(this._ServerIp);
            this.groupBox1.Controls.Add(this.MaxConn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(22, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 306);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "网络基础配置";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(4, 156);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 17);
            this.label13.TabIndex = 19;
            this.label13.Text = "补丁下载端口";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(30, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "用户名";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(6, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "数据库密码";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(6, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 27;
            this.label9.Text = "数据库端口";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(18, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 17);
            this.label10.TabIndex = 29;
            this.label10.Text = "账号库名";
            // 
            // DbAuth
            // 
            this.DbAuth.BackColor = System.Drawing.Color.White;
            this.DbAuth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DbAuth.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DbAuth.Location = new System.Drawing.Point(91, 216);
            this.DbAuth.Name = "DbAuth";
            this.DbAuth.Size = new System.Drawing.Size(108, 23);
            this.DbAuth.TabIndex = 28;
            this.DbAuth.Text = "auth";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(16, 258);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 17);
            this.label11.TabIndex = 31;
            this.label11.Text = "角色库名";
            // 
            // DbChara
            // 
            this.DbChara.BackColor = System.Drawing.Color.White;
            this.DbChara.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DbChara.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DbChara.Location = new System.Drawing.Point(91, 256);
            this.DbChara.Name = "DbChara";
            this.DbChara.Size = new System.Drawing.Size(108, 23);
            this.DbChara.TabIndex = 30;
            this.DbChara.Text = "characters";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Ismb4);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.DbChara);
            this.groupBox2.Controls.Add(this.DbAddr);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.ServerVersion);
            this.groupBox2.Controls.Add(this.DbAuth);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.DbPort);
            this.groupBox2.Controls.Add(this.DbUser);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.DbPwd);
            this.groupBox2.Location = new System.Drawing.Point(22, 346);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 331);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据库配置";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(6, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 17);
            this.label12.TabIndex = 18;
            this.label12.Text = "utf8mb4";
            // 
            // ClientList
            // 
            this.ClientList.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ClientId,
            this.ClientIp,
            this.ClientMac,
            this.ClientOs});
            this.ClientList.ContextMenuStrip = this.contextMenuStrip1;
            this.ClientList.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.ClientList.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientList.FullRowSelect = true;
            this.ClientList.GridLines = true;
            this.ClientList.HideSelection = false;
            this.ClientList.Location = new System.Drawing.Point(293, 276);
            this.ClientList.Name = "ClientList";
            this.ClientList.Size = new System.Drawing.Size(913, 443);
            this.ClientList.TabIndex = 33;
            this.ClientList.UseCompatibleStateImageBehavior = false;
            this.ClientList.View = System.Windows.Forms.View.Details;
            this.ClientList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ClientList_ItemSelectionChanged);
            // 
            // ClientId
            // 
            this.ClientId.Text = "连接Id";
            this.ClientId.Width = 100;
            // 
            // ClientIp
            // 
            this.ClientIp.Text = "客户端IP";
            this.ClientIp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ClientIp.Width = 200;
            // 
            // ClientMac
            // 
            this.ClientMac.Text = "Mac地址";
            this.ClientMac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ClientMac.Width = 200;
            // 
            // ClientOs
            // 
            this.ClientOs.Text = "客户端系统";
            this.ClientOs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ClientOs.Width = 260;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCloseConn,
            this.MenuBanClient});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 48);
            // 
            // MenuCloseConn
            // 
            this.MenuCloseConn.Name = "MenuCloseConn";
            this.MenuCloseConn.Size = new System.Drawing.Size(148, 22);
            this.MenuCloseConn.Text = "断开连接";
            this.MenuCloseConn.Click += new System.EventHandler(this.MenuCloseConn_Click);
            // 
            // MenuBanClient
            // 
            this.MenuBanClient.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox2,
            this.toolStripTextBox1,
            this.BanTime});
            this.MenuBanClient.Name = "MenuBanClient";
            this.MenuBanClient.Size = new System.Drawing.Size(148, 22);
            this.MenuBanClient.Text = "封禁该客户端";
            this.MenuBanClient.Click += new System.EventHandler(this.MenuBanClient_Click);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Enabled = false;
            this.toolStripTextBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox2.Text = "输入封禁时间(秒)";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Enabled = false;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Text = "按回车键确认";
            // 
            // BanTime
            // 
            this.BanTime.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.BanTime.Name = "BanTime";
            this.BanTime.Size = new System.Drawing.Size(100, 23);
            this.BanTime.Text = "3600";
            this.BanTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BanTime_KeyPress);
            // 
            // BanList
            // 
            this.BanList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BanList.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BanList.FormattingEnabled = true;
            this.BanList.Location = new System.Drawing.Point(760, 235);
            this.BanList.Name = "BanList";
            this.BanList.Size = new System.Drawing.Size(352, 25);
            this.BanList.TabIndex = 34;
            this.BanList.DropDown += new System.EventHandler(this.BanList_DropDown);
            this.BanList.SelectedIndexChanged += new System.EventHandler(this.BanList_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(698, 241);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 17);
            this.label14.TabIndex = 35;
            this.label14.Text = "封禁列表";
            // 
            // RemoveBan
            // 
            this.RemoveBan.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RemoveBan.Location = new System.Drawing.Point(1128, 235);
            this.RemoveBan.Name = "RemoveBan";
            this.RemoveBan.Size = new System.Drawing.Size(75, 23);
            this.RemoveBan.TabIndex = 36;
            this.RemoveBan.Text = "解除封禁";
            this.RemoveBan.UseVisualStyleBackColor = true;
            this.RemoveBan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RemoveBan_MouseClick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(287, 240);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 17);
            this.label15.TabIndex = 37;
            this.label15.Text = "连接人数";
            // 
            // ConnCount
            // 
            this.ConnCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConnCount.Enabled = false;
            this.ConnCount.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ConnCount.Location = new System.Drawing.Point(349, 238);
            this.ConnCount.Name = "ConnCount";
            this.ConnCount.Size = new System.Drawing.Size(65, 23);
            this.ConnCount.TabIndex = 38;
            this.ConnCount.Text = "0";
            this.ConnCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(447, 240);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 17);
            this.label16.TabIndex = 39;
            this.label16.Text = "是否禁用游戏ip";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label17.Location = new System.Drawing.Point(26, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 17);
            this.label17.TabIndex = 41;
            this.label17.Text = "运行时间";
            // 
            // SerRunTIme
            // 
            this.SerRunTIme.AutoSize = true;
            this.SerRunTIme.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SerRunTIme.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.SerRunTIme.Location = new System.Drawing.Point(85, 9);
            this.SerRunTIme.Name = "SerRunTIme";
            this.SerRunTIme.Size = new System.Drawing.Size(65, 17);
            this.SerRunTIme.TabIndex = 42;
            this.SerRunTIme.Text = "0时0分0秒";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LabRemainTime
            // 
            this.LabRemainTime.AutoSize = true;
            this.LabRemainTime.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabRemainTime.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LabRemainTime.Location = new System.Drawing.Point(111, 671);
            this.LabRemainTime.Name = "LabRemainTime";
            this.LabRemainTime.Size = new System.Drawing.Size(84, 17);
            this.LabRemainTime.TabIndex = 44;
            this.LabRemainTime.Text = "0天0时0分0秒";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label19.Location = new System.Drawing.Point(25, 671);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(80, 17);
            this.label19.TabIndex = 43;
            this.label19.Text = "网关过期时间";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(278, 46);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(56, 17);
            this.label18.TabIndex = 20;
            this.label18.Text = "网站首页";
            // 
            // website
            // 
            this.website.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.website.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.website.Location = new System.Drawing.Point(340, 46);
            this.website.Name = "website";
            this.website.Size = new System.Drawing.Size(361, 23);
            this.website.TabIndex = 21;
            this.website.Text = "www.baidu.com";
            this.tooltip.SetToolTip(this.website, "跳转到网站的链接");
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(278, 90);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(56, 17);
            this.label20.TabIndex = 45;
            this.label20.Text = "充值页面";
            // 
            // paywebsite
            // 
            this.paywebsite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paywebsite.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.paywebsite.Location = new System.Drawing.Point(339, 89);
            this.paywebsite.Name = "paywebsite";
            this.paywebsite.Size = new System.Drawing.Size(361, 23);
            this.paywebsite.TabIndex = 46;
            this.paywebsite.Text = "www.baidu.com";
            this.tooltip.SetToolTip(this.paywebsite, "跳转到充值页面的链接");
            // 
            // MainConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1218, 731);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.paywebsite);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.website);
            this.Controls.Add(this.LabRemainTime);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.SerRunTIme);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.BanSql);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.ConnCount);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.RemoveBan);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.BanList);
            this.Controls.Add(this.ClientList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(10000, 0);
            this.MaximizeBox = false;
            this.Name = "MainConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录器配置";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainConfig_FormClosed_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox dev_switch;
        private System.Windows.Forms.ToolTip tooltip;
        private System.Windows.Forms.Label _ServerName;
        private System.Windows.Forms.TextBox ServerName;
        private System.Windows.Forms.TextBox ServerPort;
        private System.Windows.Forms.Label _ServerPort;
        private System.Windows.Forms.Label _ServerIp;
        private System.Windows.Forms.TextBox ServerIp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MaxConn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ServerVersion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PackageSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox WorkerPoolSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DbAddr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DbUser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox DbPwd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox DbPort;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox DbAuth;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox DbChara;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox Ismb4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox HttpPort;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListView ClientList;
        private System.Windows.Forms.ColumnHeader ClientId;
        private System.Windows.Forms.ColumnHeader ClientIp;
        private System.Windows.Forms.ColumnHeader ClientMac;
        private System.Windows.Forms.ColumnHeader ClientOs;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuCloseConn;
        private System.Windows.Forms.ToolStripMenuItem MenuBanClient;
        private System.Windows.Forms.ComboBox BanList;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button RemoveBan;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripTextBox BanTime;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox ConnCount;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox BanSql;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label SerRunTIme;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LabRemainTime;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox website;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox paywebsite;
    }
}


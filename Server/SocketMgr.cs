using System;
using System.Net.Sockets;
using System.Net.WebSockets;
using System.Threading;
using System.Windows.Forms;

namespace WowServer.Server
{
    internal class SocketMgr
    {
        public static Socket ClientWebSocket;        //socket
        private SocketClientAsync ClientLink;//客户端连接对象
        private string Client_IP = "127.0.0.1";//服务端IP地址
        private int Client_Port = 8888;//服务端监听的端口号
        private Thread Client_Td;//通讯内部使用线程
        private bool ClientLinkRes = false;//服务器通讯状态标志

        private static SocketMgr instance; // 单例实例

        public static SocketMgr Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SocketMgr();
                }
                return instance;
            }
        }

        public SocketMgr()
        {
            var config = JsonObj.Instance;
            Client_IP = config.Host;
            Client_Port = config.TcpPort;
        }

        /// <summary>
        /// 启动线程
        /// </summary>
        public void StartServer()
        {
            Client_Td = new Thread(LinkSocketSerFunc);
            Client_Td.Start();
        }

        /// <summary>
        /// 重连服务端线程
        /// </summary>
        private void LinkSocketSerFunc()
        {
            while (true) // 无限循环进行重连
            {
                try
                {
                    if (!ClientLinkRes)
                    {
                        ClientLink = new SocketClientAsync(Client_IP, Client_Port, 0);
                        ClientWebSocket = ClientLink.clientSocket;
                        ClientLink.OnMsgReceived += new SocketClientAsync.ReceiveMsgHandler(Client_OnMsgReceived); // 绑定接受到服务端消息的事件
                        ClientLinkRes = ClientLink.ConnectServer();
                    }
                    else
                    {
                        // 此处写通讯成功的逻辑处理
                    }
                }
                catch (Exception ex)
                {
                    ClientLinkRes = false;
                    System.Diagnostics.Debug.WriteLine(ex.ToString());
                }

                if (!ClientLinkRes)
                {
                    // 连接失败的逻辑处理
                    Thread.Sleep(1000); // 等待1秒后进行下一次重连
                }
                else
                {
                    break; // 连接成功，跳出循环
                }
            }
        }


        /// <summary>
        /// 接收消息处理
        /// </summary>
        /// <param name="info"></param>
        private void Client_OnMsgReceived(byte[] info, int i)
        {
            try
            {
                if (info.Length > 0 && info[0] != 0)//BCR连接错误NO
                {
                    //info为接受到服务器传过来的字节数组，需要进行什么样的逻辑处理在此书写便可   
                    if (Utils.TryParse(info, out int id, out string content))
                    {
                        //处理解包后的逻辑
                        var res = PacketHandle.ProcessReceivedPacket(id, content);
                        if (res != null)
                        {
                            ClientLink.Send(res);
                        }
                    }
                }
                else
                {
                    ClientLinkRes = false;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }


        /// <summary>
        /// 终止服务
        /// </summary>
        public void StopServer()
        {
            if (ClientLinkRes)
            {
                ClientLink.CloseLinkServer();
                ClientLink.Dispose();
            }
        }

        //获取剩余时间.
        public void GetRemainTime()
        {
            // 构建包
            byte[] packet = Utils.BuildPacket(100, "1");
            ClientWebSocket.Send(packet);
        }

        public void CloseClient(string ConnId,string macAddr)
        {
            if (ClientWebSocket == null || !ClientWebSocket.Connected)
            {
                MessageBox.Show("请先启动服务");
                return;
            }

            var mac = Utils.GetMACAddress();
            var config = JsonObj.Instance;
            if (config.Develop == false)
            {
                if (mac == macAddr)
                {
                    MessageBox.Show("只有在开发者模式下才能对自己进行操作");
                    return;
                }
            }


            // 构建包
            byte[] packet = Utils.BuildPacket(102, ConnId);
            ClientWebSocket.Send(packet);

            if (int.TryParse(ConnId, out int tmpId))
            {
                GlobalData.Instance.RemoveClient(tmpId);
            }
            else
            {
                return;
            }
        }

        //ban封禁
        public void BanClient(string ConnId, string ipAddr, string macAddr, string expireTime)
        {
            if (ClientWebSocket == null || !ClientWebSocket.Connected)
            {
                MessageBox.Show("请先启动服务");
                return;
            }

            var mac = Utils.GetMACAddress();
            var config = JsonObj.Instance;
            if (config.Develop == false)
            {
                if (mac == macAddr)
                {
                    MessageBox.Show("只有在开发者模式下才能对自己进行操作");
                    return;
                }

            }


            string data = ConnId + "#" + ipAddr + "#" + macAddr + "#" + expireTime;
            // 构建包
            byte[] packet = Utils.BuildPacket(103, data);
            ClientWebSocket.Send(packet);

            if (int.TryParse(ConnId, out int tmpId))
            {
                GlobalData.Instance.RemoveClient(tmpId);
            }
            else
            {
                return;
            }
        }

        //ban解封
        public void RemoveBanClient(string ipAddr,string macAddr)
        {
            var mac = Utils.GetMACAddress();
            var config = JsonObj.Instance;
            if (config.Develop == false)
            {
                if(mac == macAddr)
                {
                    MessageBox.Show("只有在开发者模式下才能对自己进行操作");
                    return;
                }
            }
            if (ClientWebSocket == null || !ClientWebSocket.Connected)
            {
                MessageBox.Show("请先启动服务");
                return;
            }
            // 构建包
            byte[] packet = Utils.BuildPacket(104,  ipAddr +"#"+ macAddr);
            ClientWebSocket.Send(packet);
        }
    }
}

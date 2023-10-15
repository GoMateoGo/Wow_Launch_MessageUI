using System;
using System.Windows.Forms;

namespace WowServer.Server
{
    internal class PacketHandle
    {

        // 调用处理消息的方法
        public static byte[] ProcessReceivedPacket(int id, string content)
        {
            if (id == 100) 
            {
                long result;

                if (Int64.TryParse(content, out result))
                    Helper.remainTime = result;
                else
                    // 转换失败，输入的字符串无法转换为 Int64 类型
                    Helper.remainTime = 0;
            }
            //注册账号
            if (id == 1)
            {
                MessageBox.Show(content);
                return null;
            }
            //关闭指定链接
            if (id == 102)
            {
                // 使用 '#' 字符分割字符串，结果将存储在字符串数组中
                string[] splitData = content.Split('#');
                if (int.TryParse(splitData[0], out int ConnId))
                {
                    //MessageBox.Show("102数据包解析完毕");
                    GlobalData.Instance.AddClient(ConnId, splitData[1], splitData[2], splitData[3]);
                }
                else
                {
                    MessageBox.Show("转换失败，输入字符串不是有效的整数。");
                    return null;
                }
            }
            //取系统信息,mac和os
            if (id == 101)
            {
                try
                {
                    string mac =  Utils.GetMACAddress();

                    if (mac == "")
                    {
                        mac = "怀疑试图隐藏";
                    }

                    //获得操作系统版本
                    string osVersion = Utils.GetClientOs();

                    //组装信息
                    string result = mac + "#" + osVersion;


                    // 构建包
                    byte[] packet = Utils.BuildPacket(101, result);
                    var socket = SocketMgr.Instance;
                    socket.GetRemainTime();
                    // 发送包给服务器
                    return packet;

                }
                catch (Exception ex)
                {
                    // 处理发送消息错误
                    Console.WriteLine("发送消息错误：" + ex.Message);
                    return null;
                }
            }
            //客户端离线
            if (id == 105)
            {
                if (int.TryParse(content, out int number))
                {
                    GlobalData.Instance.RemoveClient(number);
                }
                return null;
                
            }
           return null;
        }

    }
}

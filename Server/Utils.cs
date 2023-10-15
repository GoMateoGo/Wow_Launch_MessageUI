using System.Net.NetworkInformation;
using System.Net;
using System;
using System.Windows.Forms;
using System.Text;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading.Tasks;
using System.Linq;

namespace WowServer.Server
{
    internal class Utils
    {
        public static string GetMACAddress()
        {
            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();

            NetworkInterface activeInterface = interfaces.FirstOrDefault(
                iface => iface.OperationalStatus == OperationalStatus.Up &&
                         (iface.NetworkInterfaceType == NetworkInterfaceType.Ethernet ||
                          iface.NetworkInterfaceType == NetworkInterfaceType.Wireless80211));

            if (activeInterface != null)
            {
                PhysicalAddress address = activeInterface.GetPhysicalAddress();
                byte[] bytes = address.GetAddressBytes();

                string macAddress = string.Join(":", bytes.Select(b => b.ToString("X2")));
                return macAddress;
            }

            return string.Empty;

        }

        //获得客户端系统信息
        public static string GetClientOs()
        {
            string Os = "";
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                Os = RuntimeInformation.OSDescription;

                // Windows 操作系统
                Console.WriteLine("操作系统：" + RuntimeInformation.OSDescription);
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                Os = RuntimeInformation.OSDescription;
                // Linux 操作系统
                Console.WriteLine("操作系统：" + RuntimeInformation.OSDescription);
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                Os = RuntimeInformation.OSDescription;
                // macOS 操作系统
                Console.WriteLine("操作系统：" + RuntimeInformation.OSDescription);
            }
            return Os;
        }


        //检测端口是否冲突
        public bool IsPortInUse(int port)
        {
            IPGlobalProperties ipGlobalProperties = IPGlobalProperties.GetIPGlobalProperties();
            IPEndPoint[] tcpEndPoints = ipGlobalProperties.GetActiveTcpListeners();

            foreach (IPEndPoint endPoint in tcpEndPoints)
            {
                if (endPoint.Port == port)
                {
                    return true;
                }
            }

            return false;
        }

        //解析数据包
        public static bool TryParse(byte[] data, out int id, out string content)
        {
            id = 0;
            content = null;

            try
            {
                // 检查数据是否足够解析
                if (data.Length < 8)
                {
                    MessageBox.Show("包长度获取错误:", data.Length.ToString());
                    return false; // 数据不足，无法解析
                }

                // 读取包长度和包 ID
                int length = BitConverter.ToInt32(data, 0);
                id = BitConverter.ToInt32(data, 4);

                // 检查数据是否足够包含内容
                if (data.Length < 8 + length)
                {
                    string res = "数据不足,无法解析:" + data.Length.ToString() + length.ToString();
                    MessageBox.Show(res);
                    return false; // 数据不足，无法解析
                }

                // 读取包内容并将其转换为字符串（使用 UTF-8 编码）
                content = Encoding.UTF8.GetString(data, 8, length);

                return true; // 解析成功
            }
            catch (Exception)
            {
                return false; // 解析失败
            }
        }


        //封包
        public static byte[] BuildPacket(int id, string content)
        {
            try
            {
                byte[] contentBytes = Encoding.UTF8.GetBytes(content);
                int length = contentBytes.Length;

                byte[] idBytes = BitConverter.GetBytes(id);
                byte[] lengthBytes = BitConverter.GetBytes(length);

                byte[] package = new byte[8 + length];
                lengthBytes.CopyTo(package, 0);
                idBytes.CopyTo(package, 4);
                contentBytes.CopyTo(package, 8);

                return package;
            }
            catch (Exception)
            {
                // 处理封包失败的情况
                return null;
            }
        }
    }
}

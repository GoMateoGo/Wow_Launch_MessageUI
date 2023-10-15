using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace WowServer.Server
{
    internal class Http
    {
        private static Http instance;

        // 私有构造函数，防止外部实例化
        private Http()
        {
        }

        // 获取单例实例的方法
        public static Http Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Http();
                }
                return instance;
            }
        }

        public Task<bool> ConnectHttp(string ip, int port)
        {
            TcpClient client = new TcpClient();

            string serverIpAddress = ip;
            int serverPort = port;

            try
            {
                client.Connect(serverIpAddress, serverPort);
                return Task.FromResult(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("启动失败连接http：" + ex.Message);
                return Task.FromResult(false);
            }

        }

        //启动http服务POST请求
        public async Task<bool> SendHttpGetStartRequest()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var config = JsonObj.Instance;
                    var mac = Utils.GetMACAddress();
                    // 创建要发送的内容
                    var content = new StringContent(mac+"#"+ "RunSocketServer");
                    // 发送 POST 请求
                    HttpResponseMessage response = await client.PostAsync($"http://{config.Host}:{config.HttpPort}/run", content);
                    // 发送 GET 请求，包含查询参数
                    //HttpResponseMessage response = await client.GetAsync($"http://{config.Host}:{config.HttpPort}/?name=RunSocketServer");

                    if (response.IsSuccessStatusCode)
                    {
                        // 请求成功，处理响应
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("下载服务器启动失败：" + response.StatusCode);
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("发送请求失败" + $"Error: {ex.Message}");
                    return false;
                }
            }
        }

        //发送关闭进程请求
        public async Task<string> SendHttpGetStopRequest()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var config = JsonObj.Instance;

                    var mac = Utils.GetMACAddress();
                    // 创建要发送的内容
                    var content = new StringContent(mac + "#" + "StopSocketServer");
                    // 发送 POST 请求
                    HttpResponseMessage response = await client.PostAsync($"http://{config.Host}:{config.HttpPort}/run", content);

                    // 检查是否成功获取响应
                    if (response.IsSuccessStatusCode)
                    {
                        // 读取响应内容并返回
                        return await response.Content.ReadAsStringAsync();
                    }
                    else
                    {
                        return "下载服务器 请求错误:关闭服务.";
                    }
                }
                catch (Exception ex)
                {
                    return $"Error: {ex.Message}";
                }
            }
        }


    }
}

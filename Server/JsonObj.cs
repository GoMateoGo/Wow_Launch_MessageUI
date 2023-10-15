using System;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace WowServer.Server
{
    internal class JsonObj
    {
        public class ConfigJson
        {
            public bool Develop { get; set; }
            public string Name { get; set; }
            public string Host { get; set; }
            public Int32 TcpPort { get; set; }
            public Int32 HttpPort { get; set; }
            public Int32 MaxConn { get; set; }
            public string Version { get; set; }
            public Int32 MaxPackageSize { get; set; }
            public Int32 WorkerPoolSize { get; set; }
            public string AuthDsn { get; set; }
            public string CharaDsn { get; set; }
            public bool BanSql { get; set; }
            public string WebSite { get; set; }
            public string PayWebSite { get; set; }
        }

        private static ConfigJson _config;

        // 获取单例配置对象
        public static ConfigJson Instance
        {
            get
            {
                if (_config == null)
                {
                    _config = LoadFromJsonFile();
                }
                return _config;
            }
        }

        // 从指定的 JSON 文件加载数据并返回 ConfigJson 对象
        private static ConfigJson LoadFromJsonFile()
        {
            try
            {
                // 指定 JSON 文件的路径
                string jsonContent = File.ReadAllText("./conf/config.json");
                return JsonSerializer.Deserialize<ConfigJson>(jsonContent);
            }
            catch (Exception)
            {
                MessageBox.Show("json反序列化失败");
                // 处理异常情况
                return null;
            }
        }
    }
}

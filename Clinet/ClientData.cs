using System;
using System.Collections.Generic;
using WowServer;

public struct ClientInfo
{
    public int ConnId { get; set; }
    public string IpAddr { get; set; }
    public string MacAddr { get; set; }
    public string OsVersion { get; set; }
}

public class GlobalData
{
    // 声明一个事件
    public event Action DataUpdated;

    private static GlobalData _instance;
    public List<ClientInfo> ClientList { get; private set; }

    private GlobalData()
    {
        ClientList = new List<ClientInfo>();
    }

    public static GlobalData Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new GlobalData();
            }
            return _instance;
        }
    }

    // 删除数据
    public void RemoveClient(int connId)
    {
        ClientList.RemoveAll(client => client.ConnId == connId);
        // 触发事件通知数据已经更新
        OnDataUpdated();
    }

    public void ClearnAll()
    {
        ClientList.Clear();
        // 触发事件通知数据已经更新
        OnDataUpdated();
    }

    //添加数据
    public void AddClient(int connId, string ip, string mac, string os)
    {
        // 创建新的ClientInfo对象
        ClientInfo newClient = new ClientInfo
        {
            ConnId = connId,
            IpAddr = ip,
            MacAddr = mac,
            OsVersion = os
        };

        // 添加到ClientList
        ClientList.Add(newClient);

        // 触发事件通知数据已经更新
        OnDataUpdated();
    }

    // 触发事件的方法
    private void OnDataUpdated()
    {
        DataUpdated?.Invoke();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WowServer
{
    internal class Helper
    {
        //socket连接
        public static bool CocketSwitch = false;
        //ban文件
        public static readonly string BanPath = Application.StartupPath + "\\Ban.txt";

        public static Int64 remainTime = 0;
    }
}

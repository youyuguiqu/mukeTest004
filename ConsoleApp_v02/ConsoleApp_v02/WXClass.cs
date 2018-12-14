using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_v02
{
    class WXClass:IMessageInfo
    {
        #region IMessageInfo 成员

        public void SendMsg()
        {
            Console.WriteLine("wx message");
        }

        #endregion
    }
}

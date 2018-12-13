using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_v02
{
    class SMSClass:IMessageInfo
    {
        #region IMessageInfo 成员

        public void SendMsg()
        {
            Console.WriteLine("SMS信息");
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_v02
{
    class Common
    {
        public static void SendMessage(AbstractFactory factory) 
        {
            IMessageInfo msg = factory.createPru();
            msg.SendMsg();
        }
    }
}

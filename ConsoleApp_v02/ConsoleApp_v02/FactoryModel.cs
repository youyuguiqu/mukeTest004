using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_v02
{
    class FactoryModel
    {
        public IMessageInfo CreateObject(string type) 
        {
            IMessageInfo msg = null;
            switch (type)
            {
                case "sms":
                    msg = new SMSClass();
                    break;
                case "mail":
                    msg = new MailClass();
                    break;
                default:
                    break;
            }
            return msg;
        }
    }
}

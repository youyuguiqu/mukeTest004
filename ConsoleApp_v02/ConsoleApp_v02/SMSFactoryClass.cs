﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_v02
{
    class SMSFactoryClass:AbstractFactory
    {
        #region AbstractFactory 成员

        public IMessageInfo createPru()
        {
            return new SMSClass();
        }

        #endregion
    }
}

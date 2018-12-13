﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_v02
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("请输入你的选项：sms 或者 mail");
                string s = Console.ReadLine();
                if ("exit".Equals(s) || "quit".Equals(s))
                {
                    break;
                }
                else
                {
                    IMessageInfo msg = null;
                    FactoryModel model = new FactoryModel();
                    if ("sms".Equals(s))
                    {
                        msg = model.CreateObject(s);
                        msg.SendMsg();
                    }
                    else if ("mail".Equals(s))
                    {
                        msg = model.CreateObject(s);
                        msg.SendMsg();
                    }
                    else
                    {
                        Console.WriteLine("没有改选项！");
                    }
                }
            }
        }
    }
}

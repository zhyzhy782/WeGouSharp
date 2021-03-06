﻿using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeGouSharp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //加载log4net配置
            FileInfo configFile = new FileInfo(AppDomain.CurrentDomain.BaseDirectory + "log4net.config");
            XmlConfigurator.ConfigureAndWatch(configFile);
            //创建logger
             var logger = LogManager.GetLogger(typeof(Program));

            //调用示例
            Test.run();
           
        }
    }
}

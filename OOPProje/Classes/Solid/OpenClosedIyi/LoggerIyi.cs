using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProje.Classes.Solid.OpenClosedIyi
{
    public class LoggerIyi
    {
        public ILogger iLogger;

        public LoggerIyi(ILogger iLogger)
        {
            this.iLogger = iLogger;
        }  
        
        public string LogKayit(string value)
        {
            return iLogger.Log(value);
        }
    }
}

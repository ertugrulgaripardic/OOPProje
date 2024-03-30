using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProje.Classes.Solid.OpenClosedIyi
{
    public class XmlLogIyi : ILogger
    {
        public string Log(string message)
        {
            return message + " xml e kaydedildi";
        }
    }
}

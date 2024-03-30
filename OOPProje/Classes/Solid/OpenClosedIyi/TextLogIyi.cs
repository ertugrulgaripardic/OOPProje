using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProje.Classes.Solid.OpenClosedIyi
{
    public class TextLogIyi : ILogger
    {
        public string Log(string message)
        {
            return message + " text e kaydedildi";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProje.Classes.Solid.OpenClosedKotu
{
    public class Logger
    {
        public DbLog dbLog;
        public XmlLog xmlLog;


        public Logger(DbLog dbLog, XmlLog xmlLog)
        {
            this.dbLog = dbLog;
            this.xmlLog = xmlLog;
        }

        public void LogKayit(LogType type, string message)
        {

            //if type() {  }  else 
            switch (type )
            {
                case LogType.Db:
                    dbLog.Kayit(message);
                    break;
                case LogType.Xml:
                    xmlLog.XmlKayit(message);
                    break;
            }
        }
    }
}

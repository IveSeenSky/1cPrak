using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPrakApp.AppData
{
    internal class Connection
    {
        public static DatabaseLocalEntities c;
        public static DatabaseLocalEntities context
        {
            get
            {
                if (c == null)
                    c = new DatabaseLocalEntities();
                return c;
            }
        }
    }
}

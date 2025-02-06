using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WpfPrakApp.AppData
{
    public partial class Employees
    {
    
        public string[] stringsName
        {
            get
            {
                string[] fio = new string[3];
                string x = EmployeeName;
                foreach (string s in fio)
                {
                    fio = x.Split(new char[] { '\u0020' }, StringSplitOptions.RemoveEmptyEntries);
                }
                return fio;
            }
        }

        public string firstName
        {
            
            get { return stringsName[0]; }
        }
        public string secondName
        {
            get { return stringsName[1]; }
        }
        public string patronymic
        {
            get { return stringsName[2]; }
        }
    }
}

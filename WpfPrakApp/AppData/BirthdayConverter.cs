using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPrakApp.AppData
{
    public partial class Employees
    {
        DateTime today = DateTime.Today;
        int _age;
        public string age
        {
            get
            {
                _age = today.Year - EmployeeBirthday.Year;
                if (_age%10 <= 4)
                {
                    return $"{_age} г.";
                }
                else if (_age%10 > 4)
                {
                    return $"{_age} л.";
                }
                else
                    return null;
            }
        }
    }
}

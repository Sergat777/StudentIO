using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentIO.DataBase
{
    public partial class Employee
    {
        public string FIO
        {
            get
            {
                string result = SecondNameEmployee + " " + FirstNameEmployee[0] + ". ";

                if (!string.IsNullOrWhiteSpace(MiddleNameEmployee))
                    result += MiddleNameEmployee[0] + ".";

                return result;
            }
        }
    }
}

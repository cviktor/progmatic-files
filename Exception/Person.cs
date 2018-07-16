using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog
{
    class Person
    {
        private int _salary;

        public int Salary
        {
            get { return _salary; }
            set
            {
                if (value >= 0) //TODO bejelzés
                {
                    _salary = value;
                }
                else
                {
                    throw new InvalidSalaryException(value);
                }
            }
        }

    }
}

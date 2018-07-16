using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog
{
    class InvalidSalaryException : Exception
    {
        public int InvalidSalary { get; private set; }

        public InvalidSalaryException(int invalidSalary) : base()
        {
            InvalidSalary = invalidSalary;
        }

        public InvalidSalaryException(int invalidSalary, string message) : base(message)
        {
            InvalidSalary = invalidSalary;
        }

        public InvalidSalaryException(int invalidSalary, string message, Exception inner) : base(message, inner)
        {
            InvalidSalary = invalidSalary;
        }
    }
}

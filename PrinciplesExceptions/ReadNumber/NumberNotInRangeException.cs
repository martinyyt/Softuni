using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadNumber
{
    public class NumberNotInRangeException : FormatException
    {
        public NumberNotInRangeException(string message):base(message)
        {
        }
    }
}

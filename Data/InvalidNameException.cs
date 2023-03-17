using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2.Data
{
    public class InvalidNameException : Exception
    {
        public InvalidNameException() : base("Invalid Name") { }

        public InvalidNameException(string message) : base(message) { }
    }
}

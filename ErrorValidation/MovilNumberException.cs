using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorValidation
{
    internal class MovilNumberException : ApplicationException
    {
        string message;
        public MovilNumberException(string message)
        {
            this.message = message;
        }
        public string Message
        {
            get { return this.message; }
        }

    }
}

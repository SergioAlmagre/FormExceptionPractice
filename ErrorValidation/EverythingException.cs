using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorValidation
{
    internal class EverythingException : ApplicationException
    {
        string message;
        public EverythingException(string message)
        {
            this.message = message;
        }
        public string Message { get { return this.message; } }
    }
}

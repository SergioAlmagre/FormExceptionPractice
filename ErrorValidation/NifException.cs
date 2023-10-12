using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorValidation
{
    internal class NifException : ApplicationException
    {
        string message;
        public NifException(string message)
        {
            this.message = message;
        }
        public string Message
        {
            get { return this.message; }
        }
    }
}

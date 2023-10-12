using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorValidation
{
    internal class AccountNumberException : ApplicationException
    {
        string message;
        public AccountNumberException(string message)
        {
            this.message = message;
        }
        public string Message
        {
            get { return this.message; }
        }
    }
}

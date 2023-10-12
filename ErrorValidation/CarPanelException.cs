using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorValidation
{
    internal class CarPanelException:ApplicationException
    {
        string message;
        public CarPanelException(string message) 
        {
           this.message = message;
        }
        public string Message 
        {
            get { return this.message; }
        }
    }
}

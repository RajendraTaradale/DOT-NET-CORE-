using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RTKW.DataService
{
    public class CustomerException : Exception
    {
        public CustomerException()
        { }

        public CustomerException(string message)
            : base(message)
        { }

        public CustomerException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}

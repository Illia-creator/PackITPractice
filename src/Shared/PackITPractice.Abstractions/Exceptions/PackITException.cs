using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackITPractice.Abstractions.Exceptions
{
    public abstract class PackITException : Exception
    {
        public PackITException(string message) : base(message)
        {
        }
    }
}

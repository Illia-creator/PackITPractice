using PackITPractice.Abstractions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackITPractice.Domain.Exceptions
{
    public class EmptyPackingListIdException : PackITException
    {
        public EmptyPackingListIdException() : base("Id cannot be null!")
        {
        }
    }
}

using PackITPractice.Abstractions.Exceptions;

namespace PackITPractice.Domain.Exceptions
{
    public class EmptyPackingListNameException : PackITException
    {
        public EmptyPackingListNameException() : base(message:("Packing list name cannot be Empty"))
        { }
    }
}

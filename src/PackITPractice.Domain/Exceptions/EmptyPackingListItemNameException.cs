using PackITPractice.Abstractions.Exceptions;

namespace PackITPractice.Domain.Exceptions
{
    public class EmptyPackingListItemNameException : PackITException
    {
        public EmptyPackingListItemNameException() : base(message: ("Packing item name cannot be Empty"))
        { }
    }
}

using PackITPractice.Domain.Exceptions;

namespace PackITPractice.Domain.ValueObjects
{
    public record PackingItem
    {
        public string Name { get; }
        public uint Qantity { get; }
        public bool IsPacked { get; }

        public PackingItem(string name, uint qantity, bool isPacked)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new EmptyPackingListItemNameException();

            Name = name;
            Qantity = qantity;
            IsPacked = isPacked;
        }
    }
}

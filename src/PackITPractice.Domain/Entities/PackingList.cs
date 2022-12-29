using PackITPractice.Domain.Exceptions;
using PackITPractice.Domain.ValueObjects;

namespace PackITPractice.Domain.Entities
{
    public class PackingList
    {
        public Guid Id { get; private set; }
          
        private PackingListName name;
        private Localization localization;

        private readonly LinkedList<PackingItem> items = new();

        internal PackingList(Guid id, PackingListName name, Localization localization, LinkedList<PackingItem> items)
        {
            this.Id = id;
            this.name = name;
            this.localization = localization;
        }

        public void AddItem(PackingItem item)
        {
            var alreadyExists = items.Any(i => i.Name == i.Name);

            if (alreadyExists)
                throw new PackingItemAlreadyExistsException(name, item.Name);

            items.AddLast(item);
        }
    }
}

namespace PackITPractice.Domain.Entities
{
    public class PackingList
    {
        public Guid Id { get; private set; }

        private string name;
        private string localization;

        internal PackingList(Guid id, string name, string localization)
        {
            this.Id = id;
            this.name = name;
            this.localization = localization;
        }
    }
}

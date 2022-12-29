namespace PackITPractice.Abstractions.Domain
{
    public abstract class AggregateRoot<T>
    {
        public T id { get; protected set; }
        public int Version { get; protected set; }

        public bool incrementVersion;

        public AggregateRoot()
        {
            if (incrementVersion)
                return;

            Version++;
            incrementVersion = true;
        }
    }
}

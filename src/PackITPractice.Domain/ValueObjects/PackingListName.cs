using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackITPractice.Domain.ValueObjects
{
    public record PackingListName
    {
        public string Value { get; }

        public PackingListName(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new Exceptions.EmptyPackingListNameException();

            Value = value;
        }

        public static implicit operator string(PackingListName name)
            => name.Value;

        public static implicit operator PackingListName(string name)
            => new(name);
    }
}

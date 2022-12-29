using PackITPractice.Abstractions.Domain;
using PackITPractice.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackITPractice.Domain.ValueObjects
{
    public record PackingListId 
    {
        public Guid Value { get; }

        public PackingListId( Guid value)
        {
            if (value == Guid.Empty)
                throw new EmptyPackingListIdException();
        }

        public static implicit operator Guid(PackingListId id)
           => id.Value;

        public static implicit operator PackingListId(Guid id)
            => new(id);
    }
}

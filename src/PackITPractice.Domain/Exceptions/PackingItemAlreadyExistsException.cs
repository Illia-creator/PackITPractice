using PackITPractice.Abstractions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackITPractice.Domain.Exceptions
{
    public class PackingItemAlreadyExistsException : PackITException
    {
        public string ListName { get; }
        public string ItemName { get; }
        public PackingItemAlreadyExistsException(string listName, string itemName) 
            : base($"Packing List : '{listName}' already have '{itemName}'")
        {
            this.ListName = listName;   
            this.ItemName = itemName;
        }
    }
}

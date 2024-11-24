using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Item : BaseEntity
    {
        public string ItemName { get; private set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public Item(int id, string itemName) : base(id)
        {
            ItemName = itemName;
        }
    }

}

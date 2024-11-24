using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Bundle : BaseEntity
    {
        public string BundleName { get; private set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public List<Item> ItemsIncluded { get; private set; }

        public Bundle(int id, string bundleName, List<Item> itemsIncluded) : base(id)
        {
            BundleName = bundleName;
            ItemsIncluded = itemsIncluded ?? new List<Item>();
        }
    }

}

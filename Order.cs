using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Order : BaseEntity
    {
        public User OrderedBy { get; private set; }
        public List<Item> OrderedItems { get; private set; }
        public string OrderStatus { get; set; }
        public decimal TotalAmount { get; private set; }

        public Order(int id, User orderedBy, List<Item> orderedItems, decimal totalAmount) : base(id)
        {
            OrderedBy = orderedBy;
            OrderedItems = orderedItems ?? new List<Item>();
            TotalAmount = totalAmount;
            OrderStatus = "Pending";
        }
    }

}

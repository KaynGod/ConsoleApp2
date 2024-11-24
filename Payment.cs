using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Payment : BaseEntity
    {
        public Order RelatedOrder { get; private set; }
        public string PaymentMethod { get; set; } // e.g., "Credit Card"
        public decimal AmountPaid { get; private set; }
        public bool IsPaymentSuccessful { get; set; }

        public Payment(int id, Order relatedOrder, decimal amountPaid) : base(id)
        {
            RelatedOrder = relatedOrder;
            AmountPaid = amountPaid;
        }
    }

}

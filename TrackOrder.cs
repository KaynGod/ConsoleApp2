using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class TrackOrder
    {
        public int OrderId { get; private set; }
        public DateTime OrderDate { get; private set; }
        public string CurrentStatus { get; set; }
        public string DeliveryEstimate { get; set; }

        public TrackOrder(int orderId, DateTime orderDate, string currentStatus, string deliveryEstimate)
        {
            OrderId = orderId;
            OrderDate = orderDate;
            CurrentStatus = currentStatus;
            DeliveryEstimate = deliveryEstimate;
        }
    }

}

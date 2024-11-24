using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class AdminDashboard
    {
        public int TotalUsers { get; set; }
        public int TotalOrders { get; set; }
        public decimal TotalRevenue { get; set; }
        public int PendingOrders { get; set; }
        public int CompletedOrders { get; set; }

        public AdminDashboard(int totalUsers, int totalOrders, decimal totalRevenue, int pendingOrders, int completedOrders)
        {
            TotalUsers = totalUsers;
            TotalOrders = totalOrders;
            TotalRevenue = totalRevenue;
            PendingOrders = pendingOrders;
            CompletedOrders = completedOrders;
        }
    }

}

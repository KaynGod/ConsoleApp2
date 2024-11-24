using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class DataAnalysis
    {
        public int TotalSales { get; set; }
        public decimal AverageOrderValue { get; set; }
        public int TotalItemsSold { get; set; }
        public int MonthlyActiveUsers { get; set; }
        public Dictionary<string, int> SalesByCategory { get; private set; }

        public DataAnalysis()
        {
            SalesByCategory = new Dictionary<string, int>();
        }

        public void AddSalesData(string category, int salesCount)
        {
            if (SalesByCategory.ContainsKey(category))
            {
                SalesByCategory[category] += salesCount;
            }
            else
            {
                SalesByCategory[category] = salesCount;
            }
        }
    }

}

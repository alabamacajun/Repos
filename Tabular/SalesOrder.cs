using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabular
{
    public enum OrderTypes : int
    {
        NullOrder = 0,
        Normal,
        Recurring,
        Special
    }

    public class SalesOrder
    {
        public string CustomerID { get; set; }
        public string OrderNumber { get; set; }
        public OrderTypes OrderType { get; set; }
        public decimal ProductTotal { get; set; }
        public decimal WeightLbs { get; set; }

    }
}

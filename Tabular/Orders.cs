using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabular
{
    public class Orders
    {
        private List<SalesOrder> _orders;

        public Orders()
        {
            _orders = new List<SalesOrder>(10);
        }

        public Orders(IEnumerable<SalesOrder> orders)
        {
            _orders = new List<SalesOrder>(10);
            _orders.AddRange(orders);
        }

        public IEnumerable<SalesOrder> GetWhere(Func<OrderTypes, bool> filter)
        {
            return _orders.Where(s => filter(s.OrderType));
        }

        public static SomeObject GetMin(SomeObject[] someObjects) => someObjects.Min(v);

        public static SomeObject GetMax(SomeObject[] someObjects) => someObjects.FirstOrDefaultsomeObjects.Max(v => v.SomeVal);
    }
}

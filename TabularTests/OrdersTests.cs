using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tabular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabular.Tests
{
    [TestClass()]
    public class OrdersTests
    {
        [TestMethod()]
        public void GetWhereTest()
        {
            var assignment = new List<SalesOrder>(5);
            assignment.Add(new SalesOrder() { OrderType = OrderTypes.Normal, CustomerID = "C1", OrderNumber = "N1", ProductTotal = 100.00M, WeightLbs = 10 });
            assignment.Add(new SalesOrder() { OrderType = OrderTypes.Normal, CustomerID = "C2", OrderNumber = "N2", ProductTotal = 1000.00M, WeightLbs = 120 });
            assignment.Add(new SalesOrder() { OrderType = OrderTypes.Special, CustomerID = "C1", OrderNumber = "S1", ProductTotal = 55.00M, WeightLbs = 13 });
            assignment.Add(new SalesOrder() { OrderType = OrderTypes.Recurring, CustomerID = "C1", OrderNumber = "R1", ProductTotal = 20.00M, WeightLbs = 80 });
            assignment.Add(new SalesOrder() { OrderType = OrderTypes.NullOrder, CustomerID = "XX", OrderNumber = "X1", ProductTotal = 0.00M, WeightLbs = 0 });
            var orderme = new Orders(assignment);
            var result1 = orderme.GetWhere((ot => ot == OrderTypes.Recurring));
            var result2 = orderme.GetWhere((ot => ot == OrderTypes.Normal));
            var result3 = orderme.GetWhere((ot => ot != OrderTypes.Normal));
            Assert.AreEqual(1, result1.Count());
            Assert.AreEqual(2, result2.Count());
            Assert.AreEqual(3, result3.Count());
            Assert.IsFalse(result3.Any(o => o.OrderNumber.StartsWith("N") || o.OrderType== OrderTypes.Normal));
        }

        [TestMethod]
        public void MinMaxTest()
        {
            // Assign
            SomeObject[] assigned = new SomeObject[]
                {
                    new SomeObject() { name = "A", SomeVal = 12.5 },
                    new SomeObject() { name = "B", SomeVal = 18.5 },
                    new SomeObject() { name = "C", SomeVal = 5.0 },
                    new SomeObject() { name = "D", SomeVal = 1.5 },
                    new SomeObject() { name = "E", SomeVal = 2.5 }
                };
            var expetedMin = 1.5;
            var expetedMax = 18.5;
            //act
            var resultMin = Orders.GetMin(assigned);
            var resultMax = Orders.GetMax(assigned);
            // Assert
            Assert.AreEqual(expetedMin, resultMin.SomeVal);
            Assert.AreEqual(expetedMax, resultMax.SomeVal);
        }
    }
}
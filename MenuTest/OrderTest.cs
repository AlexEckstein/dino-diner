using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest
{
    public class OrderTest
    {
        [Fact]
        public void SubtotalCantBeNegative()
        {
            Order order = new Order();
            order.Items.Add(new MeteorMacAndCheese());
            order.Items.Add(new Test());
            Assert.True(order.SubtotalCost >= 0);
        }


        [Fact]
        public void ShouldGiveCorrectSubTotalPrice()
        {
            Order o = new Order();
            o.Items.Add(new Brontowurst());
            o.Items.Add(new JurrasicJava());
            o.Items.Add(new Fryceritops());
            Assert.Equal<double>(6.94, o.TotalCost);
        }

        private class Test : IOrderItem
        {
            public double Price { get { return -50.00; } }
            public string Description => throw new NotImplementedException();

            public string[] Special => throw new NotImplementedException();
        }
    }
}

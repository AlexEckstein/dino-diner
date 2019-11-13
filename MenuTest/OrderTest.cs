using DinoDiner.Menu;
using System;
using System.ComponentModel;
using Xunit;

namespace MenuTest
{
    public class OrderTest
    {
        [Fact]
        public void SubtotalCantBeNegative()
        {
            Order order = new Order();
            order.Add(new MeteorMacAndCheese());
            order.Add(new Test());
            Assert.True(order.SubtotalCost >= 0);
        }


        [Fact]
        public void ShouldGiveCorrectSubTotalPrice()
        {
            Order o = new Order();
            o.Add(new Brontowurst());
            o.Add(new JurassicJava());
            o.Add(new Fryceritops());
            Assert.Equal<double>(6.94, o.TotalCost);
        }

        private class Test : IOrderItem
        {
            public double Price { get { return -50.00; } }
            public string Description => throw new NotImplementedException();

            public string[] Special => throw new NotImplementedException();

            public event PropertyChangedEventHandler PropertyChanged;
        }
    }
}

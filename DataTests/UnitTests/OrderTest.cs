/*OrderTest.cs
 * 
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Xunit;
using CowboyCafe.Data;



namespace CowboyCafe.DataTests
{
    /// <summary>
    /// Tests for the Order class
    /// </summary>
    public class OrderTest
    {
        /// <summary>
        /// Mock order item for testing
        /// </summary>
        class MockOrderItem : IOrderItem
        {
            public double Price { get; set; }
            public IEnumerable<string> SpecialInstructions { get; set; }
        }

        [Fact]
        //Adding to or should have it appear in Items
        public void AddedIOrderItemsAppearInItems()
        {
            var Order = new Order();
            var item = new MockOrderItem();
            Order.Add(item);
            Assert.Contains(item, Order.Items);
        }

        [Fact]
        //Removing something should remove it from Items
        public void RemovedOrderItemDoesNotAppearInItems()
        {
            var order = new Order();
            var item = new MockOrderItem();
            order.Add(item);
            order.Remove(item);
            
            Assert.DoesNotContain(item, order.Items);
        }

        [Theory]
        [InlineData(new double[] {0})]
        [InlineData(new double[] { 10, 15, 18 })]
        [InlineData(new double[] { 20, -4, 3.6, 8 })]
        [InlineData(new double[] {-4, -5, -66.6})]
        //Get Subtotal- Must be as expected based on added items
        public void SubtotalIsSumOfOrderItemsPrices(double[] Prices)
        {
            var order = new Order();
            double total = 0.00;
            foreach(var price in Prices)
            {
                total += price;
                order.Add(new MockOrderItem() { Price = price });
            }

            Assert.Equal(total, order.Subtotal);
        }

        [Fact]
        public void ItemsShouldContainOnlyAddedItems()
        {
            var Items = new IOrderItem[]
            {
                new MockOrderItem() {Price = 3.33},
                new MockOrderItem() {Price = 4.33},
                new MockOrderItem() {Price = 6.33}
            };

            Order order = new Order();
            foreach(var item in Items)
            {
                order.Add(item);
            }
            Assert.Equal(Items.Length, order.Items.Count());
            foreach(var item in Items)
            {
                Assert.Contains(item, order.Items);
            }
        }
        


    }
}

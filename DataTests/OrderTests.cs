﻿using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using Xunit;
using System.Linq;

namespace CowboyCafe.DataTests
{
    class MockOrderItem : IOrderItem
    {
        public double Price { get; set; }

        public uint Calories { get; set; }

        public List<string> SpecialInstructions { get; set; }
    }

    public class OrderTests
    {
        //Adding something to the order should
        //have it appear in the order
        [Fact]
        public void AddedIOrderItemAppearInItemsProperty()
        {
            var order = new Order();
            var item = new MockOrderItem();
            order.Add(item);
            Assert.Contains(item, order.Items);
        }

        [Fact]
        public void RemovedOrderItemDoesNotAppearInItems()
        {
            var order = new Order();
            var item = new MockOrderItem();
            order.Add(item);
            order.Remove(item);
            Assert.DoesNotContain(item, order.Items);
        }

        //Removing something from the order should
        //remove it from the Items proprety 

        [Theory]
        [InlineData(new double[] { 0 })]
        [InlineData(new double[] {10, 15, 18})]
        [InlineData(new double[] { 20, -4, 3.6, 8})]
        [InlineData(new double[] { -100, -5})]
        [InlineData(new double[] { })]
        public void SubtotalShouldBeTheSumOfAllItemsAdded(double[] prices)
        {
            var order = new Order();
            double total = 0;
            foreach(var price in prices)
            {
                total += price;
                order.Add(new MockOrderItem(){
                    Price = price
                });
            }
            Assert.Equal(total, order.Subtotal);
        }

      

        [Fact]
        
        public void ItemsShouldContainOnlyTheAddedITems()
        {
            var items = new IOrderItem[]
            {
                new MockOrderItem() {Price = 3},
                new MockOrderItem() {Price = 4},
                new MockOrderItem() {Price = 7},
            };

            var order = new Order();
            foreach(var item in items)
            {
                order.Add(item);
            }
            Assert.Equal(items.Length, order.Items.Count());
            foreach(var item in items)
            {
                Assert.Contains(item, order.Items);
            }
        }

        


    }
}

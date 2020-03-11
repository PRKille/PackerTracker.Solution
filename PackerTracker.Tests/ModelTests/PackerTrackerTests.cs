using Microsoft.VisualStudio.TestTools.UnitTesting;
using PackerTracker.Models;
using System.Collections.Generic;
using System;

namespace PackerTracker.Test
{
  [TestClass]
  public class PackerTrackerTests
  {   
    [TestMethod]
    public void ConstructorAddsIdCorrectly_IdIsListCount_1()
    {
      Item newItem1 = new Item("banana", 1, true, false);
      Item newItem2 = new Item("bandana", 3, true, true);
      Assert.AreEqual(1, newItem1.Id);
    }

    [TestMethod]
    public void GetAllUnpurchased_ReturnsListOfAllUnpurchasedItems_List()
    {
      Item newItem1 = new Item("banana", 1, false, false);
      Item newItem2 = new Item("bandana", 3, true, true);
      List<Item> unperchased = new List<Item> {newItem1};
      Assert.AreEqual(unperchased.Count, Item.GetAllUnpurchased().Count);
    }

    [TestMethod]
    public void GetAllUnpurchased_ReturnsListOfCorrectUnpurchasedItems_List()
    {
      Item newItem1 = new Item("banana", 1, false, false);
      Item newItem2 = new Item("bandana", 3, true, true);
      List<Item> unperchased = new List<Item> {newItem1};
      Assert.AreEqual(unperchased[0].Type, Item.GetAllUnpurchased()[0].Type);
    }

    [TestMethod]
    public void MarkPurchased_UpdatePurchasedBool_True()
    {
      Item newItem1 = new Item("banana", 1, false, false);
      Item newItem2 = new Item("bandana", 3, true, true);
      Item.GetAllUnpurchased();
      foreach(Item item in Item.GetAll())
      if (item.Purchased == false)
      {
        item.MarkPurchased();
      }
      Assert.AreEqual(Item.GetAll()[0].Purchased, true);
    }
  }
}
using System;
using System.Collections.Generic;

namespace PackerTracker.Models
{
  public class Item
  {
    public string Type { get; set; }
    public int Cost { get; set; }
    public bool Purchased { get; set; }
    public bool Packed { get; set; }
    public int Id { get; }
    private static List<Item> _items = new List<Item> {};

  public Item (string type, int cost)
  {
    Type = type;
    Cost = cost;
    Purchased = false;
    Packed = false;
    _items.Add(this);
    Id = _items.Count;
  }
  public static List<Item> GetAll()
  {
    return _items;
  }

  public static void CLearAll()
  {
    _items.Clear();
  }
  
  public static List<Item> GetAllUnpurchased()
  {
    List<Item> unpurchased = new List<Item>();
    foreach(Item item in _items)
    {
      if (item.Purchased == false)
      {
        unpurchased.Add(item);
      }
    }
    return unpurchased;
  }

  public void MarkPurchased()
  {
    Purchased = true;
  }

  public void MarkPacked()
  {
    Packed = true;
  }
  }
}


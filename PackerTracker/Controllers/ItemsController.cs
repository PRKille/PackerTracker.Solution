using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PackerTracker.Models;

namespace PackerTracker.Controllers
{
  public class ItemsController : Controller
  {
    [HttpGet("/items/new")]
    public ActionResult New()
    {
        return View();
    }

    [HttpPost("/items")]
    public ActionResult Create(string type, int cost)
    {
      Item newItem = new Item(type, cost);
      return RedirectToAction("Items");
    }

    [HttpGet("/items")]
    public ActionResult Items()
    {
      List<Item> itemList = Item.GetAll();
      return View(itemList);
    }

    [HttpPost("/items/{id}")]
    public ActionResult Update(int id, string value)
    {
      Item purchasedItem = Item.GetAll()[id-1];
      if (value == "purchased")
      {
        purchasedItem.MarkPurchased();
        return RedirectToAction("Items");
      }
      else
      {
        purchasedItem.MarkPacked();
        return RedirectToAction("Items");
      }
    }
  }
}
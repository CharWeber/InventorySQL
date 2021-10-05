using Microsoft.AspNetCore.Mvc;
using Inventory.Models;
using System.Collections.Generic;
using System.Linq;

namespace Inventory.Controllers
{
  public class RecordsController : Controller
  {
    private readonly InventoryContext _db;

    public RecordsController(InventoryContext db)
    {
      _db = db;
    }
  }
}
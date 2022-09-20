using CafeProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CafeProject.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        // GET: Item
        // 1. *********** Display All Item List in Index Page ***********
        public ActionResult Index()
        {
            ViewBag.ItemList = "Item List Page";
            ItemDbHandler IHandler = new ItemDbHandler();
            ModelState.Clear();
            return View(IHandler.GetItemList());
        }
        
        public ActionResult Admin()
        {
            return View();
        }

        // 2. *********** Add New Item ***********
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(ItemList iList)
        {
            // try
            //{
            if (ModelState.IsValid)
            {
                ItemDbHandler ItemHandler = new ItemDbHandler();
                if (ItemHandler.InsertItem(iList))
                {
                    ViewBag.Message = "Item Added Successfully";
                    ModelState.Clear();
                }
            }
            return View();
            /* }
             catch { return View();  }*/
        }

        // 3. *********** Update Item Details ***********
        [HttpGet]
        public ActionResult Edit(int id)
        {
            ItemDbHandler ItemHandler = new ItemDbHandler();
            return View(ItemHandler.GetItemList().Find(itemmodel => itemmodel.ID == id));
        }
        [HttpPost]
        public ActionResult Edit(ItemList iList)
        {
            try
            {
                ItemDbHandler ItemHandler = new ItemDbHandler();
                ItemHandler.UpdateItem(iList);
                return RedirectToAction("Index");
            }
            catch { return View(); }
        }

        // 4. *********** Delete Item Details ***********
        public ActionResult Delete(int id)
        {
            try
            {
                ItemDbHandler ItemHandler = new ItemDbHandler();
                if (ItemHandler.DeleteItem(id))
                {
                    ViewBag.AlertMsg = "Item Deleted Successfully";
                }
                return RedirectToAction("Index");
            }
            catch { return View(); }
        }

        public ActionResult Details(int id)
        {
            ItemDbHandler ItemHandler = new ItemDbHandler();
            return View(ItemHandler.GetItemList().Find(itemmodel => itemmodel.ID == id));
        }
    }
}
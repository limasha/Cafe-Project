using CafeProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CafeProject.Controllers
{
    public class PointofSaleController : Controller
    {
        // GET: PointofSale
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PointofSale()
        {
            SendData();
            return View();
        }

        public JsonResult SendData()
        {
            ItemDbHandler db = new ItemDbHandler();
            List<ItemList> list = db.GetItemList();
            //var result = db.GetItemList();
            return Json(new { data = list }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult OrderIndex()
        {
            ViewBag.ItemList = "Item List Page";
            OrderDbHandler IHandler = new OrderDbHandler();
            ModelState.Clear();
            return View(IHandler.GetOrderList());
        }

        [HttpGet]
        public ActionResult PlaceOrder()
        {
           
            return View();
      
        }

        [HttpPost]
        public ActionResult PlaceOrder(OrderList iList)
        {
            // try
            //{
            if (ModelState.IsValid)
            {
                OrderDbHandler OrderHandler = new OrderDbHandler();
                if (OrderHandler.InsertOrder(iList))
                {
                    ViewBag.Message = "Order Added Successfully";
                    ModelState.Clear();
                }
            }
            return View();
            /* }
             catch { return View();  }*/
        }

        //  Delete Order Details
        public ActionResult Delete(int id)
        {
            try
            {
                OrderDbHandler ItemHandler = new OrderDbHandler();
                if (ItemHandler.DeleteItem(id))
                {
                    ViewBag.AlertMsg = "Order Deleted Successfully";
                }
                return RedirectToAction("OrderIndex");
            }
            catch { return View(); }
        }
    }
}
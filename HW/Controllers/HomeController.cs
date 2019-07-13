using HW.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<RecordsViewModel> recordList = new List<RecordsViewModel>();
            #region 亂數產生100筆假資料    
            Random random = new Random();

            for (int i = 0; i < 100; i++)
            {
                RecordsViewModel record = new RecordsViewModel();
                record.Category = random.Next(0, 2) == 1 ? "收入" : "支出";
                record.Price = random.Next(1, 100) * 10;

                DateTime start = new DateTime(2018, 1, 1);
                int range = (DateTime.Today - start).Days;
                record.BuyDate = start.AddDays(random.Next(range));

                recordList.Add(record);
            }
            #endregion
            return View(recordList);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
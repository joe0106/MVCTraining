using HW.Models.ViewModels;
using HW.Repository;
using HW.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW.Controllers
{
    public class HomeController : Controller
    {
        private readonly AccountService _accountService;
        private readonly UnitOfWork _unitOfWork;

        public HomeController()
        {
            _unitOfWork = new UnitOfWork();
            _accountService = new AccountService(_unitOfWork);            
        }

        public ActionResult Index()
        {
            List<RecordsViewModel> recordList = _accountService.Lookup().ToList();
            #region 亂數產生100筆假資料    
            //Random random = new Random();

            //for (int i = 0; i < 100; i++)
            //{
            //    RecordsViewModel record = new RecordsViewModel();
            //    record.Category = random.Next(0, 2) == 1 ? "收入" : "支出";
            //    record.Price = random.Next(1, 100) * 10;

            //    DateTime start = new DateTime(2018, 1, 1);
            //    int range = (DateTime.Today - start).Days;
            //    record.BuyDate = start.AddDays(random.Next(range));

            //    recordList.Add(record);
            //}
            #endregion
            return View(_accountService.Lookup());
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
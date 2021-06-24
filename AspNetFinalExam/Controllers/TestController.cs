using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetFinalExam.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNetFinalExam.Controllers
{
    public class TestController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(new TestData());
        }
        [HttpPost]

        public IActionResult Index(TestData data)
        {
            if (data.Name == "1")
            {
                data.Message = "星期一";
            }
            else if (data.Name == "2")
            {
                data.Message = "星期二";
            }
            else if (data.Name == "3")
            {
                data.Message = "星期三";
            }
            else if (data.Name == "4")
            {
                data.Message = "星期四";
            }
            else if (data.Name == "5")
            {
                data.Message = "星期五";
            }
            else if (data.Name == "6")
            {
                data.Message = "星期六";
            }
            else if (data.Name == "7")
            {
                data.Message = "星期七";
            }
            else
            {
                data.Message = "Error";
            }
            return View(data);

        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aman.BookStore.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
           //var obj = new { Id=1,Name="Aman"};
            return View();
           // return View("ContactUs",obj);
           // return View("../../Tempo/TempView");// for relative path
           // return View("Tempo/TempView.cshtml");//full path with extension
        } 
        public ViewResult ContactUs()
        {
            return View();
        }
    }
}

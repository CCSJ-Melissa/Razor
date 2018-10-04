using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Razor.Models;

namespace Razor.Controllers
{
        public class HomeController : Controller
        {

            public ViewResult Index() {
            Product myProduct = new Product {
                  Product[] array = {
                        new Product {Name = "Kayak", Price = 275M},
                        new Product {Name = "LifeJacket", Price = 48.95M},
                        new Product {Name = "Soccer ball", Price = 19.50M},
                        new Product {Name = "Coner flag", Price = 34.95M},
                    };
                    return View(array);
            }
        }
    }


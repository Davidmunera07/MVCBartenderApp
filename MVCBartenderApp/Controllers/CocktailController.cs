using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCBartenderApp.Models;

namespace MVCBartenderApp.Controllers
{
    public class CocktailController : Controller
    {
        private ICocktailRepository repository;

        public CocktailController(ICocktailRepository repo)
        {
            repository = repo;
        }

        public ViewResult List() => View(repository.Cocktails);

        public ViewResult Index()
        {
            return View("Index");
        }
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Wxt.OnlineCakeStore.Domain;

namespace Wxt.OnlineCakeStore.WebApp.Controllers
{
    public class CakeController : Controller
    {
        private IStoreRepository repository;
        public CakeController(IStoreRepository storeRepository)
        {
            this.repository = storeRepository;
        }

        // GET: Cake
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult List()
        {
            return View(repository.Cakes);
        }
    }
}
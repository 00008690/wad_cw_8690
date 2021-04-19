using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WAD._8690.APP.Models;
using WAD._8690.APP.Models.Builders;

namespace WAD._8690.APP.Controllers
{
    public class ArrangedProductController : Controller
    {
        // GET: ArrangedProductController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ArrangedProductController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ArrangedProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ArrangedProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product collection)
        {
            try
            {
                var d = new Director();
                var b = new ArrangedProductBuilder();
                d.Builder = b;

                d.BuildPremiumProduct(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ArrangedProductController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ArrangedProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ArrangedProductController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ArrangedProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

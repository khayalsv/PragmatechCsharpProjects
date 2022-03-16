﻿using KS.Extension;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using NoTech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoTech.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CounterController : Controller
    {
        private readonly MyContext myContext;
        private readonly IWebHostEnvironment env; //image

        public CounterController(MyContext myContext, IWebHostEnvironment env)
        {
            this.myContext = myContext;
            this.env = env;
        }

        [HttpGet]
        public IActionResult List()
        {
            var item = myContext.Counters.ToList();
            return View(item);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var item = new Counter();
            return View(item);
        }


        [HttpPost]
        public async Task<IActionResult> Create(Counter item)
        {
            if (!ModelState.IsValid) return View(item); //datanin olmadigini yoxluyur


            await myContext.Counters.AddAsync(item);
            await myContext.SaveChangesAsync();

            return Redirect("List");
        }


        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();

            var item = myContext.Counters.Find(id);

            if (item == null) return NotFound();

            return View(item);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(Counter item)
        {
            if (!ModelState.IsValid) return View(item);

            var list = myContext.Counters.Find(item.ID);

           

            list.Odometer = item.Odometer;
            list.Text = item.Text;
            list.Title = item.Title;
            list.Icon = item.Icon;


            await myContext.SaveChangesAsync();
            return Redirect("/Admin/Counter/List");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var item = await myContext.Counters.FindAsync(id);

            if (item == null) return NotFound();

            myContext.Counters.Remove(item);
            await myContext.SaveChangesAsync();

            TempData["Success"] = "Item deleted!";

            return Redirect("/Admin/Counter/List");

        }

        //AJAX
        [HttpPost]
        public async Task<JsonResult> CreateAjax(string odometer, string title, string text, string icon)
        {
            if (odometer== null && title == null && text == null && icon == null)
            {
                return Json(new
                {
                    status = 400
                });
            }

            var item = new Counter()
            {
                Odometer = odometer,
                Title = title,
                Text = text,
                Icon = icon
            };

            await myContext.Counters.AddAsync(item);
            await myContext.SaveChangesAsync();

            return Json(new
            {
                status = 200
            });
        }
      
    }
}

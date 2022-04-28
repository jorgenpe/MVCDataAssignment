using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCDataAssignment.Models;

namespace MVCDataAssignment.Controllers
{
    public class PeopleController : Controller
    {
        IPeopleService _peopleService;

        public PeopleController()
        {
            _peopleService = new PeopleService();
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_peopleService.All());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(_peopleService.All());
        }

        [HttpPost]
        public IActionResult Create(CreatePersonViewModel createPerson)
        {
            if (ModelState.IsValid)
            {
                _peopleService.Add(createPerson);
                return Redirect("Index");
            }

            return View(createPerson);
        }


        [HttpPut]
        public IActionResult Edit(int id,CreatePersonViewModel createPerson)
        {
            return View(createPerson);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return View();
        }


    }
}

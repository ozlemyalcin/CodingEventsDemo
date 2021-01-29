using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodingEventsDemo.Data;
using CodingEventsDemo.Models;
using Microsoft.AspNetCore.Mvc;
using CodingEventsDemo.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace coding_events_practice.Controllers
{
    public class EventsController : Controller
    {

        // GET: /<controller>/
        public IActionResult Index()
        {
            // ViewBag.events = EventData.GetAll();

            List<Event> events = new List<Event>(EventData.GetAll());

            return View(events);
        }

        public IActionResult Add()
        {
            //Create blank AddEventViewModel to associate with the Form in Add.cshtml
            AddEventViewModel addEventViewModel = new AddEventViewModel();
            return View(addEventViewModel);
        }

        [HttpPost]
        //[Route("Events/Add")]
        public IActionResult Add(AddEventViewModel viewModel)
        {
            //Imagine doing lots of data validation on the viewModel first

            if (ModelState.IsValid)
            {
                Event newEvent = new Event
                {
                    Name = viewModel.Name,
                    Description = viewModel.Description,
                    ContactEmail = viewModel.ContactEmail,
                    Place=viewModel.Place,
                    NumOfParticipant=viewModel.NumOfParticipant


                };
                EventData.Add(newEvent);

                return Redirect("/Events");

            }
            //viewModel is NOT valid!
            return View(viewModel);

           
        }

        public IActionResult Delete()
        {
            //ViewBag.title = "Delete Events";
            ViewBag.events = EventData.GetAll();

            return View();
        }

        [HttpPost]
        public IActionResult Delete(int[] eventIds)
        {
            foreach (int eventId in eventIds)
            {
                EventData.Remove(eventId);
            }

            return Redirect("/Events");
        }
    }
}

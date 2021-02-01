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
            AddEventViewModel addEvenViewModel = new AddEventViewModel();
            return View(addEvenViewModel);
        }

        [HttpPost]
        [Route("Events/Add")]
        public IActionResult NewEvent(Event newEvent)
        {
            EventData.Add(newEvent);
      
            return Redirect("/Events");
        }

        //
        [HttpGet]
        [Route("/Events/Edit/{eventId}")]
        public IActionResult Edit(int eventId)
        {
            //Create an editEventViewModel with properties assigned from Event associated with eventId
            Event eventToEdit = EventData.GetById(eventId);

            //Use eventToEdit to populate values of editEventViewModel
            EditEventViewModel editEventViewModel = new EditEventViewModel(eventToEdit);

            return View(editEventViewModel);
        }


        //POST: /Event/Edit
        [HttpPost]
        public IActionResult Edit(EditEventViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                //Get the Event object from Event Data
                //Where does the eventId come from?-viewmodel

                Event eventToEdit = EventData.GetById(viewModel.Id);

                //Modify properties in eventToEdit, using new values in viewModel

                eventToEdit.Name = viewModel.Name;
                eventToEdit.Description = viewModel.Description;
                eventToEdit.ContactEmail = viewModel.ContactEmail;

                return Redirect("/Events");
            }
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

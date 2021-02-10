using System;
using CodingEventsDemo.Models;

namespace CodingEventsDemo.ViewModels
{
    //ViewModel that will be the @model PageModel age  for a detail model
    public class EventDetailViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ContactEmail { get; set; }
        public string CategoryName { get; set; }

        public EventDetailViewModel(Event theEvent)
        {
            Name = theEvent.Name;
            Description = theEvent.Description;
            ContactEmail = theEvent.ContactEmail;
            CategoryName = theEvent.Category.Name;
        }

    }
}

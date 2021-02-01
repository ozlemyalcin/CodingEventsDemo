using System;
using System.ComponentModel.DataAnnotations;
using CodingEventsDemo.Models;

namespace CodingEventsDemo.ViewModels
{
    public class EditEventViewModel
    {

        public int Id { get; set; }
    


        [Required(ErrorMessage="Name is required")]
        [StringLength(50, MinimumLength =3, ErrorMessage="Name must be between 3 and 50n characters")]
        public string Name { get; set; }

        [Required(ErrorMessage="Please enter a description for your event")]
        [StringLength(500, ErrorMessage="Description too long")]
        public string Description { get; set; }

        [EmailAddress]
        public string ContactEmail { get; set; }

        public EditEventViewModel() { }


        public EditEventViewModel(Event evt)
        {
            this.Id = evt.Id;
            this.Name = evt.Name;
            this.Description = evt.Description;
            this.ContactEmail = evt.ContactEmail;
        }

       
    }
}

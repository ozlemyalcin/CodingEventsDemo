using System;
using System.ComponentModel.DataAnnotations;

namespace CodingEventsDemo.ViewModels
{
    public class AddEventViewModel
    {
        [Required(ErrorMessage ="Name is required")]
        [StringLength(50, MinimumLength =3, ErrorMessage ="Name must be between 3 and 50 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Please enter a description for your event.")]
        [StringLength(500,ErrorMessage ="Description is too long.")]
        public string Description { get; set; }

        [EmailAddress]
        [Required]
        public string ContactEmail { get; set; }

        [Required(ErrorMessage ="Please enter the place of the event")]
        [StringLength(50,ErrorMessage ="Must be less than 50 characters")]
        public string Place { get; set; }

        [Required]
        [Range(0,10000)]
        public int NumOfParticipant { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using CodingEventsDemo.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CodingEventsDemo.ViewModels
{
    public class AddEventCategoryViewModel
    {
        [Required]
        [StringLength(20, MinimumLength =3)]
        public string Category { get; set; }
    }
}

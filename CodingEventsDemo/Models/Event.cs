using System;
namespace CodingEventsDemo.Models
{
    public class Event
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Event(string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }

        public override string ToString()
        {
            return base.ToString();

        }
    }
}

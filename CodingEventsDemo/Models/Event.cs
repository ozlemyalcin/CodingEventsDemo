using System;
using Microsoft.AspNetCore.Mvc;

namespace CodingEventsDemo.Models
{
    public class Event
    {
        public string Name { get; set; }

        public string Description { get; set; }
        public string ContactEmail { get; set; }
        public string Place { get; set; }
        public int NumOfParticipant { get; set; }


        public int Id { get; }
        static private int nextId = 1;

        public Event(string name, string description, string contactEmail,string place, int numOfParticipant):this()
        {
            Name = name;
            Description = description;
            ContactEmail = contactEmail;
            Place = place;
            NumOfParticipant = numOfParticipant;

        }

        public Event()
        {
            Id = nextId;
            nextId++;
        }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            return obj is Event @event &&
                   Id == @event.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}

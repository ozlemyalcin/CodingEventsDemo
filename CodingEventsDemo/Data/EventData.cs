using System;
using System.Collections.Generic;
using CodingEventsDemo.Models;

namespace CodingEventsDemo.Data
{
    public class EventData
    {
        static private Dictionary<int, Event> Events = new Dictionary<int, Event>();

        //Add behavior

        public static void Add(Event newEvent)
        {
            Events.Add(newEvent.Id, newEvent);
        }


        //GetAll behavior
        public static IEnumerable<Event> GetAll()
        {
            return Events.Values;
        }
        


        //Delete behavior
        public static void Remove(int id)
        {
            Events.Remove(id);
        }



        //GetById behavior
        public static Event GetById(int id)
        {
            return Events[id];
        }


    }
}

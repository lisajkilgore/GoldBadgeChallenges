using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_03
{
    public enum EventType {Golf, Bowling, AmusementPark, Concert  }

    public class Outings
    {
        public EventType TypeOfEvent { get; set; }
        public int PeopleAttended { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalCostPerPerson { get; set; }
        public decimal TotalCostEvent { get; set; }

        public Outings(EventType eventType, int peopleAttended, DateTime date, decimal totalCostPerPerson, decimal totalCostEvent)
        {
            TypeOfEvent = eventType;
            PeopleAttended = peopleAttended;
            Date = date;
            TotalCostPerPerson = totalCostPerPerson;
            TotalCostEvent = totalCostEvent;
        }
        public Outings()
        {

        }

        public Outings(EventType eventType, decimal totalCostEvent)
        {
            TypeOfEvent = eventType;
            TotalCostEvent = totalCostEvent;
        }
           
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_03
{
    public class OutingsRepository
    {
        List<Outings> _listOfOutings = new List<Outings>();

        public void AddOutingsToList(Outings outings)
        {
            _listOfOutings.Add(outings);
        }

        public List<Outings> GetOutingsList()
        {
            return _listOfOutings;
        }

        public decimal GetOutingsCostByType(EventType eventType)
        {
            decimal totalCost = 0;
            foreach (Outings outing in _listOfOutings)
            {
                if (eventType == outing.TypeOfEvent)
                {
                    totalCost += outing.TotalCostEvent;
                }

            }
            return totalCost;
        }

        public decimal GetTotalCost()
        {
            decimal totalCost = 0;
            foreach (Outings outing in _listOfOutings)
            {
                totalCost += outing.TotalCostEvent;
            }
            return totalCost;
        }


    }

}
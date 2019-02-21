using System;
using System.Collections.Generic;

namespace Challenge_03
{
    public class ProgramUI
    {
        public OutingsRepository _outingsRepository = new OutingsRepository();
        public List<Outings> _outingsList;
        int _response;

        public void Run()
        {
            _outingsList = _outingsRepository.GetOutingsList();
            SeedOutingsData();
            while (_response != 5)
            {
                PrintMenu();
                switch (_response)
                {
                    case 1:
                        PrintAllInList();
                        break;
                    case 2:
                        AddOutingsToList();
                        break;
                    case 3:
                        TotalCostAllEvent();
                        break;
                    case 4:
                        CostByType();
                        break;
                    case 5:
                        Console.WriteLine("Thanks for using the Outings Application.");
                        break;
                    case 6:
                    default:
                        Console.WriteLine("Please enter the correct value.");
                        break;
                }
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
            }
        }

        private void TotalCostAllEvent()
        {
            decimal totalCost = _outingsRepository.GetTotalCost();
            Console.WriteLine($"The total cost of all events is: {totalCost}");
        }

        private void CostByType()
        {
            int number = EventTypeMenu();
            EventType eventType = GetType(number);
            decimal cost = _outingsRepository.GetOutingsCostByType(eventType);
            Console.WriteLine($"Cost was: {cost} for all {eventType} outings");
        }

        private void PrintMenu()
        {
            Console.WriteLine("Choose a menu item\n\t" +
                "1. See a list of all outings\n\t" +
                "2. Add outings to the list\n\t" +
                "3. Display total cost of all outings\n\t" +
                "4. Display total cost of outings by event type\n\t" +
                "5. Exit");

            Console.WriteLine("Press any key to continue");
            _response = int.Parse(Console.ReadLine());
            Console.Clear();
        }

        private void PrintAllInList()
        {
            foreach (Outings outings in _outingsList)
            {
                Console.WriteLine($"{outings.TypeOfEvent}\t{outings.PeopleAttended}\t{outings.Date}\t{outings.TotalCostPerPerson}\t{outings.TotalCostEvent}");
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        private void AddOutingsToList()
        {
            PrintAllInList();

            Console.WriteLine("Enter the name of the outing type.");
            string eventType = Console.ReadLine();

            Console.WriteLine("Enter the number of people who attended the event.");
            int peopleAttended = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the date of the event.");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter the total cost per person.");
            decimal totalCostPerPerson = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter the total cost of the entire event.");
            decimal totalCost = decimal.Parse(Console.ReadLine());
        }

        private EventType GetType(int input)
        {
            EventType type;

            switch (input)
            {

                case 1:
                    type = EventType.Golf;
                    break;
                case 2:
                    type = EventType.Bowling;
                    break;
                case 3:
                    type = EventType.AmusementPark;
                    break;
                case 4:
                    type = EventType.Concert;
                    break;
                default:
                    type = EventType.Golf;
                    break;
            }
            return type;
        }
        private void SeedOutingsData()
        {
            _outingsRepository.AddOutingsToList(new Outings(EventType.Golf, 30, new DateTime(2018, 5, 04), 29.99m, 899.70m));
            _outingsRepository.AddOutingsToList(new Outings(EventType.Bowling, 50, new DateTime(2018, 6, 15), 20.00m, 1000.00m));
            _outingsRepository.AddOutingsToList(new Outings(EventType.AmusementPark, 65, new DateTime(2018, 5, 04), 50.00m, 3250.00m));
            _outingsRepository.AddOutingsToList(new Outings(EventType.Concert, 22, new DateTime(2018, 7, 15), 50.00m, 1100.00m));

        }


        private int EventTypeMenu()
        {
            Console.WriteLine("Select the correct number for your Event Type.\n\t" +
                "1. Golf\n\t" +
                "2. Bowling\n\t" +
                "3. Amusement Park\n\t" +
                "4. Concert\n\t" +
                "5. Other");
            int eventType = int.Parse(Console.ReadLine());

            return eventType;
        }

    }
}
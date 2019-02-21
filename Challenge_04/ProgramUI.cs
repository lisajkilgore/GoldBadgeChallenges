using System;
using System.Collections.Generic;

namespace Challenge_04
{
    public class ProgramUI
    {
        public BadgeRepository _badgeRepository = new BadgeRepository();
        Dictionary<int, List<string>> _badgeDoorAccess;
        int _response;

        public void Run()
        {
            _badgeDoorAccess = _badgeRepository.GetBadgeDoorAccessList();
            while (_response != 4)
            {
                PrintMainMenu();
                switch (_response)
                {
                    case 1:
                        AddBadgeMenu();
                        break;
                    case 2:
                        PrintEditBadgeMenu();
                        break;
                    case 3:
                        ListAllBadges();
                        break;
                    case 4:
                        Console.WriteLine("Thanks for using the Badge application.");
                        break;
                    case 5:
                    default:
                        Console.WriteLine("Please enter the correct value.");
                        break;
                }
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
            }

        }
        private void PrintMainMenu()
        {
            Console.WriteLine("Hello Security Admin, What would you like to do?\n\t" +
                    "1. Add a badge\n\t" +
                    "2. Edit a badge\n\t" +
                    "3. List all badges\n\t" +
                    "4. Exit");

            Console.WriteLine("Press any key to continue");
            _response = int.Parse(Console.ReadLine());
            Console.Clear();
        }
        private void AddBadgeMenu()
        {
            List<string> doors = new List<string>();
            Console.WriteLine("What is the badge number?");
            int badge = int.Parse(Console.ReadLine());

            Console.WriteLine("List a door that badge should be able to access.");
            string doorAccess = Console.ReadLine();

            Console.WriteLine("Should any other doors be added to that badge (y/n?)");
            string answer = Console.ReadLine();

            if (answer == "y")
            {
                Console.WriteLine("List another door to add to that badge.");
            }

            if (answer == "n")
            {
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
            }
            _badgeRepository.AddBadge(badge, doors);
        }
        private void PrintEditBadgeMenu()
        {
            Console.WriteLine("What would you like to do?\n\t" +
                "1. Remove a door from a selected badge\n\t" +
                "2. Add a door to a selected badge\n\t" +
                "3. Return to Main Menu");
        }
        private void RemoveDoorFromBadgeMenu()
        {
            Console.WriteLine("Which badge would you like to update?");
            ListAllBadges();
            var desiredBadge = int.Parse(Console.ReadLine());
            Console.WriteLine("Which door, from that badge, would you like to remove?");
            foreach (var door in _badgeDoorAccess[desiredBadge])
            {
                Console.WriteLine(door);
            }

            int desiredDoor = int.Parse(Console.ReadLine());
            _badgeDoorAccess.Remove(desiredDoor);
        }
        private void ListAllBadges()
        {
            foreach (KeyValuePair<int, List<string>> badge in _badgeDoorAccess)
            {
                Console.WriteLine($"{badge.Key}\t");
                Console.WriteLine("Door access    ");
                foreach (string displayDoors in badge.Value)
                {
                    Console.WriteLine($"{displayDoors}\n");
                }

            }
        }
    }
}
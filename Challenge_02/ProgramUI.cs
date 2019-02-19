using System;
using System.Collections.Generic;
using System.Threading;

namespace Challenge_02
{
    public class ProgramUI
    {
        public ClaimRepository _claimRepository = new ClaimRepository();
        public Queue<Claim> _claimQueue;
        int _response;


        public void Run()
        {
            _claimQueue = _claimRepository.GetClaimQueue();
            while (_response != 5)
            {
                PrintClaimsMenu();
                switch (_response)
                {
                    case 1:
                        PrintAllInQueue();
                        break;
                    case 2:
                        NextClaimInQueue();
                        break;
                    case 3:
                        AddClaimToQueue();
                        break;
                    case 4:
                        Console.WriteLine("Thanks for using the claims system");
                        break;
                    case 5:
                    default:
                        Console.WriteLine("Please enter the correct value");
                        break;
                }
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                Console.Clear();
            }
        }

        private void PrintClaimsMenu()
        {
            Console.WriteLine("Choose a menu item\n\t" +
                "1. See all claims\n\t" +
                "2. Take care of next claim\n\t" +
                "3. Enter a new claim\n\t" +
                "4. Exit");

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();
        }
        private void NextClaimInQueue()
        {
            Claim claim = _claimQueue.Peek();
            Console.WriteLine($"{claim.ClaimID}\t{claim.TypeOfClaim}\t{claim.Description}\t{claim.ClaimAmount}\t{claim.DateOfIncident}\t{claim.DateOfClaim}\t{claim.IsValid}");
        }

        private void PrintAllInQueue()
        {
            foreach (Claim claim in _claimQueue)
            {
                Console.WriteLine($"{claim.ClaimID}\t{claim.TypeOfClaim}\t{claim.Description}\t{claim.ClaimAmount}\t{claim.DateOfIncident}\t{claim.DateOfClaim}\t{claim.IsValid}");
            }
            Thread.Sleep(3000);
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        private void AddClaimToQueue()
        {
            PrintAllInQueue();

            Console.WriteLine("Enter the claim id:");
            string claimID = Console.ReadLine();

            Console.WriteLine("Enter the claim type:");
            var typeStr = Console.ReadLine().ToLower();
            var type = GetType(typeStr);

            Console.WriteLine("Enter a claim description:");
            string description = Console.ReadLine();

            Console.WriteLine("Amount of Damage:");
            decimal claimAmount = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Date Of Accident:");
            DateTime dateOfIncident = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Date of Claim:");
            DateTime dateOfClaim = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Is claim valid?");
            bool isValid = bool.Parse(Console.ReadLine());
        }
        private ClaimType GetType(string typeStr)
        {
            ClaimType type;

            switch (typeStr)
            {
                case "car":
                    type = ClaimType.Car;
                    break;
                case "home":
                    type = ClaimType.Home;
                    break;
                default:
                    type = ClaimType.Theft;
                    break;
            }
            return type;
        }
    }
}
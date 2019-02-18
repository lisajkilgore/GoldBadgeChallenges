using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_01
{
    public class ProgramUI
    {
        public MenuRepository _menuRepository = new MenuRepository();
        public List<Menu> _menuList;
        int _response;

        public void Run()
        {
            _menuList = _menuRepository.GetMenuList();
            SeedMenuData();
            while (_response != 5)
            {
                PrintMenu();
                switch (_response)
                {
                    case 1:
                        SeeAllMenuItems();
                        break;
                    case 2:
                        AddMenuItem();
                        break;
                    case 3:
                        RemoveMenuItem();
                        break;
                    case 4:
                        Console.WriteLine("Have a nice day.");
                        break;
                    case 5:
                    default:
                        Console.WriteLine("Please enter the correct value.");
                        break;
                }
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                Console.Clear();
            }
        }

        private void SeeAllMenuItems()
        {
            Console.WriteLine("Please review Menu List\n\t" +
            "1. Cheesebuger\n\t" +
            "2. Double cheeseburger\n\t" +
            "3. Chicken sandwich\n\t" +
            "4. Chicken nuggets\n\t" +
            "5. Other");

            _response = int.Parse(Console.ReadLine());
        }

        private void RemoveMenuItem()
        {
            _menuRepository.GetMenuList();
            Console.WriteLine("Enter the name of the meal you would like to remove.");
            string mealName = Console.ReadLine();

            foreach (Menu meal in _menuList)
            {
                if (mealName == meal.MealName)
                {
                    _menuRepository.RemoveMealFromMenu(meal);
                }
                break;
            }
        }

        private void AddMenuItem()
        {
            Console.WriteLine("Please enter the meal number");
            int mealNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the meal name");
            string mealName = Console.ReadLine();
            Console.WriteLine("Please enter the description.");
            string description = Console.ReadLine();
            Console.WriteLine("Please enter the ingredients.");
            string ingredients = Console.ReadLine();
            Console.WriteLine("Please enter the price.");
            decimal price = decimal.Parse(Console.ReadLine());

            Menu meal = new Menu(mealNumber, mealName, description, ingredients, price);
            _menuRepository.AddMealToMenu(meal);
        }

        private void SeedMenuData()
        {
            _menuRepository.AddMealToMenu(new Menu(1, "cheeseburger", "cheeseburger", "hamburger, cheese, bun, onion, pickles, tomato, mustard, ketchup", 2.99m));
            _menuRepository.AddMealToMenu(new Menu(2, "grilled chicken sandwich", "grilled chicken", "grilled chicken, bun, lettuce, tomato, onion, pickle, mayo", 3.99m));
        }

        private void PrintMenu()
        {
            Console.WriteLine("What would you like to do?\n\t" +
                "1. See all menu items\n\t" +
                "2. Add menu items\n\t" +
                "3. Remove menu items\n\t" +
                "4. Exit\n\t");
            _response = int.Parse(Console.ReadLine());

        }
    }
}

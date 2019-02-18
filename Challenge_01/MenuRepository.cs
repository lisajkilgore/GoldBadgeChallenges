using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_01
{
    public class MenuRepository
    {
        List<Menu> _listOfMenu = new List<Menu>();

        public void AddMealToMenu(Menu meal)
        {
            _listOfMenu.Add(meal);
        }

        public void RemoveMealFromMenu(Menu meal)
        {
            _listOfMenu.Remove(meal);
        }

        public List<Menu> GetMenuList()
        {
            return _listOfMenu;
        }
    }

}

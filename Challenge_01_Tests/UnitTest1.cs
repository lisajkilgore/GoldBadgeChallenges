using Challenge_01;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Challenge_01_Tests
{
    [TestClass]
    public class Challenge_01_Tests
    {
        [TestMethod]
        public void MenuRepository_AddMealToMenu_ShouldReturnCorrectCount()
        {
            //Arrange
            MenuRepository _menuRepository = new MenuRepository();
            List<Menu> menuList = _menuRepository.GetMenuList();
            Menu meal = new Menu();
            _menuRepository.AddMealToMenu(meal);

            //Act
            int actual = menuList.Count;
            int expected = 1;

            //Assert 
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MenuRepository_RemoveMealFromMenu_ShouldReturnCorrectCount()
        {
            //Arrange
            MenuRepository _menuRepository = new MenuRepository();
            List<Menu> menuList = _menuRepository.GetMenuList();
            Menu meal = new Menu();
            Menu mealTwo = new Menu();

            _menuRepository.AddMealToMenu(meal);
            _menuRepository.AddMealToMenu(mealTwo);

            _menuRepository.RemoveMealFromMenu(meal);

            //Act
            int actual = menuList.Count;
            int expected = 1;

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}

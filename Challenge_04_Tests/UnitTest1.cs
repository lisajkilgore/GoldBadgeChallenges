using Challenge_04;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Challenge_04_Tests
{
    [TestClass]
    public class Challenge_04_Tests
    {
        BadgeRepository _badgeRepository = new BadgeRepository();

        [TestMethod]
        public void BadgeRepository_AddDoorToList_ShouldReturnCorrectCount()
        {
            //Arrange
            var badges = _badgeRepository.GetBadgeDoorAccessList();
            _badgeRepository.AddBadge(1, new List<string>() { "a", "b", "c" });

            //Act
            var actual = badges[1].Count;
            var expected = 3;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BadgeRepository_AddDoorsToBadge_ShouldAddDoortoCorrectBadge()
        {
            //Arrange
            var doorsToBadge = _badgeRepository.GetBadgeDoorAccessList();
            _badgeRepository.AddDoorsToBadge(2, new List<string>() { "A22", "B7", "C6" });

            //Act
            var actual = doorsToBadge[2].Count;
            var expected = 3;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void BadgeRepository_AddBadge_ShouldAddNewBadge()
        {
            //Arrange
            var badge = _badgeRepository.GetBadgeDoorAccessList();
            _badgeRepository.AddBadge(3, new List<string>() { "A8", "A10", "A25", "A29" });

            //Act
            var actual = badge[3].Count;
            var expected = 4;

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void BadgeRepository_RemoveBadge_ShouldRemoveBadge()
        {
            //Arrange
            var badge = _badgeRepository.GetBadgeDoorAccessList();
            _badgeRepository.RemoveBadge(3);
            //Act
            var actual = badge.Count;
            var expected = 3;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

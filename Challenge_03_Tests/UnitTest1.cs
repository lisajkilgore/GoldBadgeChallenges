using Challenge_03;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Challenge_03_Tests
{
    [TestClass]
    public class Challenge_03_Tests
    {
        OutingsRepository _outingsRepository = new OutingsRepository();

        [TestMethod]
        public void OutingRepository_AddOutingToList_ShouldReturnCorrectCount()
        {
            //Arrange
            List<Outings> outingsList = _outingsRepository.GetOutingsList();
            _outingsRepository.AddOutingsToList(new Outings());

            //Act
            int actual = outingsList.Count;
            int expected = 1;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OutingRepository_GetTotalCost_ShouldReturnTotalCost()
        {
            //Arrange
            List<Outings> outingsList = _outingsRepository.GetOutingsList();

            Outings outings = new Outings();
            outings.TotalCostEvent = 1000m;
            _outingsRepository.AddOutingsToList(outings);

            Outings outingsTwo = new Outings();
            outingsTwo.TotalCostEvent = 500m;
            _outingsRepository.AddOutingsToList(outingsTwo);

            Outings outingsThree = new Outings();
            outingsThree.TotalCostEvent = 250m;
            _outingsRepository.AddOutingsToList(outingsThree);

            //Act
            decimal actual = _outingsRepository.GetTotalCost();
            decimal expected = 1750m;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OutingRepository_GetOutingCostByType_ShouldReturnCostByType()
        {
            //Arrange
            Outings outings = new Outings();
            outings.TypeOfEvent = EventType.Golf;
            outings.TotalCostEvent = 500m;
            _outingsRepository.AddOutingsToList(outings);

            Outings outingsTwo = new Outings();
            outingsTwo.TypeOfEvent = EventType.Bowling;
            outingsTwo.TotalCostEvent = 250m;
            _outingsRepository.AddOutingsToList(outingsTwo);

            Outings outingsThree = new Outings();
            outingsThree.TypeOfEvent = EventType.Golf;
            outingsThree.TotalCostEvent = 550m;
            _outingsRepository.AddOutingsToList(outingsThree);

            //Act
            decimal actual = _outingsRepository.GetOutingsByType(EventType.Golf);
            decimal expected = 1050m;

            //Assert 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OutingRepository_GetOutingCostByTypeTwo_ShouldReturnCostByType()
        {
            //Arrange
            Outings outings = new Outings();
            outings.TypeOfEvent = EventType.Golf;
            outings.TotalCostEvent = 500m;
            _outingsRepository.AddOutingsToList(outings);

            Outings outingsTwo = new Outings();
            outingsTwo.TypeOfEvent = EventType.Bowling;
            outingsTwo.TotalCostEvent = 250m;
            _outingsRepository.AddOutingsToList(outingsTwo);

            Outings outingsThree = new Outings();
            outingsThree.TypeOfEvent = EventType.Golf;
            outingsThree.TotalCostEvent = 550m;
            _outingsRepository.AddOutingsToList(outingsThree);

            //Act
            decimal actual = _outingsRepository.GetOutingsByType(EventType.Bowling);
            decimal expected = 250m;

            //Assert 
            Assert.AreEqual(expected, actual);
        }
    }
}

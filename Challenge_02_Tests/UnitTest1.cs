using Challenge_02;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Challenge_02_Tests
{
    [TestClass]
    public class Challenge_02_Tests
    {
        ClaimRepository _claimRepository = new ClaimRepository();
        [TestMethod]
        public void ClaimRepository_EnqueueClaim_ShouldReturnCorrectCount()
        {
            //Arrange
            Queue<Claim> claimQueue = _claimRepository.GetClaimQueue();
            _claimRepository.EnqueueClaim(new Claim());

            //Act
            int actual = claimQueue.Count;
            int expected = 1;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ClaimRepository_DequeueClaim_ShouldReturnCorrectCount()
        {
            //Arrange
            Queue<Claim> claimQueue = _claimRepository.GetClaimQueue();
            Claim claim = new Claim();
            Claim claimTwo = new Claim();
            _claimRepository.EnqueueClaim(claim);
            _claimRepository.EnqueueClaim(claimTwo);

            _claimRepository.DequeueClaim(claim);

            //Act
            int actual = claimQueue.Count;
            int expected = 1;

            //Assert 
            Assert.AreEqual(expected, actual);

        }
    }
}

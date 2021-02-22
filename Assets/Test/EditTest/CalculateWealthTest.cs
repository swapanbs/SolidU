using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class CalculateWealthTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void CalculateWealth_Test()
        {
            var WealthManager = new WealthManager();
            int pickUp = 5;
            int timePassed = 20;

            int expectedTolatWealth = (5 * 100) - 20;

            int wealth = WealthManager.Calculate(pickUp, timePassed);


            Assert.That(wealth, Is.EqualTo(expectedTolatWealth));
            // Use the Assert class to test conditions
        }

    }
}

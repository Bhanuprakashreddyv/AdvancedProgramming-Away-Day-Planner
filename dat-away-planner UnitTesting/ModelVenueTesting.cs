﻿using day_away_planner.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace dat_away_planner_UnitTesting
{
    [TestClass]
    public class ModelVenueTesting
    {
        [TestMethod]
        public void TestVenueID_IsKey()
        {
            // Arrange
            var prop = typeof(Venue).GetProperty("VenueID");

            // Act
            var keyAttr = prop.GetCustomAttribute<KeyAttribute>();

            // Assert
            Assert.IsNotNull(keyAttr);
        }
        [TestMethod]
        public void TestVenueName_IsRequired()
        {
            
            var prop = typeof(Venue).GetProperty("VenueName");
            var requiredAttr = prop.GetCustomAttribute<RequiredAttribute>();
            Assert.IsNotNull(requiredAttr);
        }

        [TestMethod]
        public void TestVenueCost_IsRequired()
        {
            
            var prop = typeof(Venue).GetProperty("VenueCost");
            var requiredAttr = prop.GetCustomAttribute<RequiredAttribute>();
            Assert.IsNotNull(requiredAttr);
        }

        [TestMethod]
        public void TestVenueLocation_IsRequired()
        {
            
            var prop = typeof(Venue).GetProperty("VenueLocation");
            var requiredAttr = prop.GetCustomAttribute<RequiredAttribute>();
            Assert.IsNotNull(requiredAttr);
        }

        [TestMethod]
        public void TestVenueCapacity_IsRequired()
        {
            
            var prop = typeof(Venue).GetProperty("VenueCapacity");
            var requiredAttr = prop.GetCustomAttribute<RequiredAttribute>();
            Assert.IsNotNull(requiredAttr);
        }
    }
}


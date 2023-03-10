//Ryan Chandler	w18009424@northumbria.ac.uk 
//Dean Rimmer	w18029848@northumbria.ac.uk
//Bhanu Prakash	w21052079@northumbria.ac.uk
//Precious Chidiadi Nwachukwu	22007369@northumbria.ac.uk
using day_away_planner.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace day_away_planner_UnitTesting
{
    [TestClass]
    public class ModelActivityTesting
    {
        [TestMethod]
        public void TestActivityID_IsKey()
        {
            // Arrange
            var prop = typeof(Activity).GetProperty("ActivityID");

            // Act
            var keyAttr = prop.GetCustomAttribute<KeyAttribute>();

            // Assert
            Assert.IsNotNull(keyAttr);
        }

        [TestMethod]
        public void TestActivityName_IsRequired()
        {
            var prop = typeof(Activity).GetProperty("ActivityName");
            var requiredAttr = prop.GetCustomAttribute<RequiredAttribute>();
            Assert.IsNotNull(requiredAttr);
        }

        [TestMethod]
        public void TestActivityCost_IsRequired()
        {
            var prop = typeof(Activity).GetProperty("ActivityCost");
            var requiredAttr = prop.GetCustomAttribute<RequiredAttribute>();
            Assert.IsNotNull(requiredAttr);
        }
        [TestMethod]
        public void TestActivityNote_IsNotRequired()
        {
            var prop = typeof(Activity).GetProperty("ActivityNote");
            var requiredAttr = prop.GetCustomAttribute<RequiredAttribute>();
            Assert.IsNull(requiredAttr);
        }
    }
}

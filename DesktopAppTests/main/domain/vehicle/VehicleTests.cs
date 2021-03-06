﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesktopApp.main.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.main.domain.Tests
{
    [TestClass()]
    public class VehicleTests
    {
        [TestMethod()]
        public void VehicleTest()
        {
            Vehicle vehicle = new Vehicle("BMW", "320i", "2006", "CA 569-412", "Brad Ripp");

            Assert.AreEqual("BMW", vehicle.Make);
            Assert.AreEqual("320i", vehicle.Model);
            Assert.AreEqual("2006", vehicle.Year);
            Assert.AreEqual("CA 569-412", vehicle.RegistrationNumber);
            Assert.AreEqual("Brad Ripp", vehicle.Owner);
        }

        [TestMethod()]
        public void GetObjectDataTest()
        {
            
        }
    }
}
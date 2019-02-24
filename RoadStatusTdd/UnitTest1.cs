using System;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoadStatus;

namespace RoadStatusTdd
{
    [TestClass]
    public class RoadStatusTests
    {
        [TestMethod]
        public void ValidRoute()
        {
            TfLRoadStatus testRoute = new TfLRoadStatus("A1");
            HttpStatusCode result = testRoute.Retrieve();
            Assert.AreEqual(HttpStatusCode.OK, result);

        }
         
        [TestMethod]
        public void displayNameRetrieved()
        {
            TfLRoadStatus testRoute = new TfLRoadStatus("A1");
            HttpStatusCode result = testRoute.Retrieve();
            Assert.AreEqual("A1", testRoute.result[0].DisplayName);
        }

        [TestMethod]
        public void statusSeverityRetrieved()
        {
            TfLRoadStatus testRoute = new TfLRoadStatus("A1");
            HttpStatusCode result = testRoute.Retrieve();
            Assert.AreEqual("Good", testRoute.result[0].StatusSeverity);

        }

        [TestMethod]
        public void statusSeverityDescriptionRetrieved()
        {
            TfLRoadStatus testRoute = new TfLRoadStatus("A1");
            HttpStatusCode result = testRoute.Retrieve();
            Assert.AreEqual("No Exceptional Delays", testRoute.result[0].StatusSeverityDescription);

        }

        [TestMethod]
        public void InvalidRoute()
        {
            TfLRoadStatus testRoute = new TfLRoadStatus("A354");
            HttpStatusCode result = testRoute.Retrieve();
            Assert.AreEqual(HttpStatusCode.NotFound, result);

        }


    }
}

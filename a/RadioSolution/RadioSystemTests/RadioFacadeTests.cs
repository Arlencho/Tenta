using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RadioSystemTests
{
    [TestClass]
    public class RadioFacadeTests
    {
        [TestMethod]
        public void Test_That_Facade_Can_Be_Created()
        {
            RadioFacade facade = new RadioFacade();
            Assert.IsNotNull(facade);
        }
        [TestMethod]
        public void Test_That_RixFM_Can_Be_Played()
        {
            RadioFacade facade = new RadioFacade();

            facade.PlayMusic("MixMegapol");
            Assert.IsTrue(facade.Is)
        }
        [TestMethod]
        public void Test_That_P3_Can_Be_Played()
        {
            RadioFacade facade = new RadioFacade();

            facade.PlayMusic("P3");
            Assert.IsTrue(facade.Is)
        }
    }
}

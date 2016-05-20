using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.QualityTools.Testing.Fakes;
using DemoFake;
using Microsoft.QualityTools.Testing.Fakes.Stubs;
using System.Collections.Fakes;
using DemoFake.Fakes;

namespace DemoFake.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGiftIsWeekend()
        {
            // Shims solo pueden ser utilizados en ShimsContext:
            using (ShimsContext.Create())
            {
                // Arrange:
                // Shim DateTime.Now para que regrese una fecha fija
                System.Fakes.ShimDateTime.NowGet = () =>
                    { return new DateTime(2016, 5, 21); };

                Gift gift = new Gift();

                // Act:
                bool status = gift.IsWeekend();

                // Assert: 
                // Siempre es true si el componente que se prueba funciona
                Assert.AreEqual(true, status);
            }


        }

        [TestMethod]
        public void TestWinner()
        {
            StubIGift stubGift = new StubIGift();
            stubGift.BirthYearInt32 = (parameter) => { return 1990; };

            Gift gift = new Gift();
            Assert.AreEqual(1990, gift.BirthYear(26));
        }
    }
}

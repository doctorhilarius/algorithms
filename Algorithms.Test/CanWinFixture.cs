using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Test {
    [TestClass]
    public class CanWinFixture {

        [TestMethod]
        public void CanWin_10_3_True() {

            var service = new CanWin();

            bool result = service.CanIWin(10, 3);

            Assert.IsTrue(result);
        }


        [TestMethod]
        public void CanWin_10_11_False() {

            var service = new CanWin();

            bool result = service.CanIWin(10, 11);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CanWin_3_4_False() {

            var service = new CanWin();

            bool result = service.CanIWin(3, 4);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CanWin_4_6_True() {

            var service = new CanWin();

            bool result = service.CanIWin(4, 6);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanWin_5_12_True() {

            var service = new CanWin();

            bool result = service.CanIWin(5, 12);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanWin_7_21_True() {

            var service = new CanWin();

            bool result = service.CanIWin(7, 21);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanWin_9_27_True() {

            var service = new CanWin();

            bool result = service.CanIWin(7, 21);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanWin_10_35_True() {

            var service = new CanWin();

            bool result = service.CanIWin(7, 21);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanWin_2_2_True() {

            var service = new CanWin();

            bool result = service.CanIWin(7, 21);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanWin_16_100_True() {

            var service = new CanWin();

            bool result = service.CanIWin(7, 21);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanWin_15_104_True() {

            var service = new CanWin();

            bool result = service.CanIWin(7, 21);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanWin_15_105_True() {

            var service = new CanWin();

            bool result = service.CanIWin(7, 21);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanWin_15_100_True() {

            var service = new CanWin();

            bool result = service.CanIWin(7, 21);

            Assert.IsTrue(result);
        }



    }
}

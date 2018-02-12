using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgsFriday.Lib.Algorithms;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ProgsFriday.Algorithms
{
    [TestClass]
    public class SearchTests
    {
        [TestMethod]
        public void TestLinearSearch()
        {
            int[] intArray = new[] { 1, 3, 44, 5, 22, 66 };

            int intArrayFoundIndex = intArray.LinearSearch(44);
            Assert.AreEqual(2, intArrayFoundIndex);

            intArrayFoundIndex = intArray.LinearSearch(33);
            Assert.AreEqual(-1, intArrayFoundIndex);


            string[] stringArray = new[] { "Arthur", "Vahan", "Albert", "Gurgen"};

            int stringArrayFoundIndex = stringArray.LinearSearch("Vahan");
            Assert.AreEqual(1, stringArrayFoundIndex);

            stringArrayFoundIndex = stringArray.LinearSearch("Armen");
            Assert.AreEqual(-1, stringArrayFoundIndex);
        }

        [TestMethod]
        public void TestBetterLinearSearch()
        {
            int[] intArray = new[] { 1, 3, 44, 5, 22, 66 };

            int intArrayFoundIndex = intArray.BetterLinearSearch(44);
            Assert.AreEqual(2, intArrayFoundIndex);

            intArrayFoundIndex = intArray.BetterLinearSearch(33);
            Assert.AreEqual(-1, intArrayFoundIndex);


            string[] stringArray = new[] { "Arthur", "Vahan", "Albert", "Gurgen" };

            int stringArrayFoundIndex = stringArray.BetterLinearSearch("Vahan");
            Assert.AreEqual(1, stringArrayFoundIndex);

            stringArrayFoundIndex = stringArray.BetterLinearSearch("Armen");
            Assert.AreEqual(-1, stringArrayFoundIndex);
        }
    }
}

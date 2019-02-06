using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode804UniqueMorseCodeWords
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var words = new string[] { "gin", "zen", "gig", "msg" };

            Solution solution = new Solution();

            var actual = solution.UniqueMorseRepresentations(words);

            var expected = 2;

            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        public void ConvertToMorseWord_gin()
        {
            var word = "gin";

            Solution solution = new Solution();

            var actual = solution.ConvertToMorseWord(word);

            var expected = "--...-.";

            Assert.AreEqual(expected, actual);
        }

    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem1_1;

namespace Problem1_1_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Single_Char_Is_Unique()
        {
            string text = "a";
            var solution = new Solution();

            bool result = solution.AreAllCharactersUnique(text);

                Assert.IsTrue(result);

        }
    }
}

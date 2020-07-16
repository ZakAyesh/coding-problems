using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Problem2_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ReverseInt()
        {
                int x = 123;
                string intString = x.ToString();
                string newString = "";

                for (int i = intString.Length - 1; i < 0; i--)
                {
                    newString += intString[i];
                }

                int result = Int32.Parse(newString);
                Console.WriteLine(result);
        }
    }
}


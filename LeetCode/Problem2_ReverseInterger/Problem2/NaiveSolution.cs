using System;

namespace Problem1
{
    public class NaiveSolution : ISolution
    {
        public int Reverse(int x)
        {
            string intString = x.ToString();
            string newString = "";

            for(int i = intString.Length - 1; i < 0; i--)
            {
                newString += intString[i];
            }

            int result = Int32.Parse(newString);
            return result;

        }
    }
}
using System;

namespace Problem1_1
{
    public class NaiveSolution: ISolution
    {
        public bool AreAllCharactersUnique(string text)
        {
            //0(1)+O(N)
            foreach (char c in text)
            {
                // O(N)
                for (int i=text.IndexOf(c) + 1; i < text.Length; i++)
                {
                    if( c == text[i])
                    {
                        return false;

                    }
                        
                }
            }

            return true;
        }
    }
}
//Solution: O(N^2)
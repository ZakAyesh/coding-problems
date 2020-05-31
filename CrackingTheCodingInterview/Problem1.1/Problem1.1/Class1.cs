using System;

namespace Problem1_1
{
    public class UniqueCharactersInString
    {
        public bool Solve(string text)
        {
            foreach (char c in text)
            {
                for (int i=text.IndexOf(c) + 1; i < text.Length; i++)
                {
                    if( c == text[1])
                    {
                        return false;

                    }
                        
                }
            }

            return true;
        }
    }
}

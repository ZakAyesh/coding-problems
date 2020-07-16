using System;
using System.Collections.Generic;

namespace Problem1_1
{
    public class Practice : ISolution
    {
        /*I can come here and practice writing the solutions from scratch.
          I must clean out the solution after each practice */
        public bool AreAllCharactersUnique(string text)
        {
         foreach(char c in text)
            {
                var hset = new HashSet<char>();
                if(!hset.Add(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
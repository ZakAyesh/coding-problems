using System.Collections.Generic;

namespace Problem1
{
    public class Solution: ISolution
    {
        public bool AreAllCharactersUnique(string text)
        {
            var hashSet = new HashSet<char>();

            foreach (char c in text)
            {
                if (!hashSet.Add(c))
                {
                    return false;
                }
            }

            return true;
        }
    }
}

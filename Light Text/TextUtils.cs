using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Light_Text
{
    /// <summary>
    /// Text Utils
    /// </summary>
    public static class TU
    {
        static int EntriesCount = 0;
        //static int currentEntry = -1;

        public static List<int> EntriesIndicies = new List<int>();

        /// <summary>
        /// Count string occurences in another string
        /// </summary>
        /// <param name="needle">String to be counted</param>
        /// <param name="haystack">String to search occurences in</param>
        /// <param name="ignorecase">Should case be ignored?</param>
        /// <returns></returns>
        public static int Count(string needle, string haystack, bool ignorecase = true)
        {
            EntriesIndicies = new List<int>();

            if (ignorecase)
            {
                haystack = haystack.ToLower();
                needle = needle.ToLower();
            }

            int found = 0;
            for (int i = -1; i < found; i++)
            {
                int index = haystack.IndexOf(needle);
                if (index != -1)
                {
                    found++;

                    int count = EntriesIndicies.Count;
                    if (count == 0)
                        EntriesIndicies.Add(index);
                    else
                        EntriesIndicies.Add(index + EntriesIndicies[count - 1] + 1);

                    haystack = haystack.Substring(++index);
                }
            }

            return found;
        }

        /// <summary>
        /// Search a string in another string and retrieve it's positions
        /// </summary>
        /// <param name="needle">String to search with</param>
        /// <param name="haystack">String to search in</param>
        /// <param name="ignorecase">Should case be ignored?</param>
        /// <returns></returns>
        public static List<int> Search(string needle, string haystack, bool ignorecase = true)
        {
            Count(needle, haystack, ignorecase);
            return EntriesIndicies;
        }
    }
}

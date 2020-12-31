using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SlidingWindow
{
    public class PermutationInString
    {
        public bool IsPermutationContains(string input, string pattern)
        {
            int windowStart = 0;
            int windowEnd = 0;
            var patternSet = new Dictionary<char, int>();
            int totalFount = 0;
            patternSet = initDictionary(input);

            while (windowEnd < input.Length)
            {
                var endChar = input[windowEnd];

                if (patternSet.ContainsKey(endChar))
                {
                    totalFount++;
                }
                else
                {
                    totalFount = 0;
                    windowStart = windowEnd + 1;
                }

                if (windowEnd - windowStart + 1 == pattern.Length && totalFount == pattern.Length)
                {
                    return true;
                }

                windowEnd++;
            }

            return false;
        }

        public bool CheckInclusion(string p, string s)
        {
            int result = 0;

            int l = p.Length;
            var sLength = s.Length;

            if (sLength == 0 || l > sLength) return false;
            //if(l == 0) return null;

            int startIndex = 0;
            int endIndex = startIndex + l - 1;

            var pDictionary = GetDictionary(p);

            var windowString = s.Substring(startIndex, l);
            var sDictionary = GetDictionary(windowString);

            var isAnagram = CheckAnagram(sDictionary, pDictionary);

            while (endIndex < s.Length)
            {
                //isAnagram = CheckAnagram(sDictionary, pDictionary);
                if (isAnagram) return true;

                char startKey = s[startIndex];
                if (sDictionary[startKey] > 1) sDictionary[s[startIndex]]--;
                else sDictionary.Remove(s[startIndex]);

                startIndex++;
                endIndex++;

                char endKey = s[endIndex];

                if (sDictionary.ContainsKey(endKey)) sDictionary[endKey]++;
                else sDictionary.Add(endKey, 1);
            }

            return false;
        }

        private bool CheckAnagram(Dictionary<char, int> sDictionary, Dictionary<char, int> pDictionary)
        {
            foreach (var key in sDictionary.Keys)
            {
                if (!pDictionary.ContainsKey(key)) return false;

                if (pDictionary[key] != sDictionary[key]) return false;

            }

            return true;
        }

        private Dictionary<char, int> GetDictionary(string p)
        {
            var dictionary = new Dictionary<char, int>();

            for (int i = 0; i < p.Length; i++)
            {
                if (!dictionary.ContainsKey(p[i]))
                {
                    dictionary.Add(p[i], 0);
                }

                dictionary[p[i]]++;
            }

            return dictionary;
        }

        private Dictionary<char, int> initDictionary(string input)
        {
            var dictionary = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                var c = input[i];

                if (!dictionary.ContainsKey(c)) dictionary.Add(c, 0);
                dictionary[c]++;
            }

            return dictionary;
        }
    }
}

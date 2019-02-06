using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode804UniqueMorseCodeWords
{
    public class Solution
    {
        public int UniqueMorseRepresentations(string[] words)
        {
            throw new NotImplementedException();
        }

        public string ConvertToMorseWord(string word)
        {
            var strBuilder = new StringBuilder();

            var chars = word.ToCharArray();

            foreach (var c in chars)
            {
                strBuilder.Append(GetMorseCode(c));
            }

            return strBuilder.ToString();
        }

        string[] morseCodes = new string[]
        {
            ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---",
            ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.."
        };

        private string GetMorseCode(char c)
        {
            var index = c - 97;
            return morseCodes[index];
        }
    }
}
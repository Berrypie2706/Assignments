using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment12
{
    public class InputValidation
    {
        public int CountWords(string inputText)
        {
            string[] words = inputText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
        public string[] EmailValidation(string inputText)
        {

            string pattern = @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}\b";

            // Create a Regex object with the pattern
            Regex regex = new Regex(pattern);

            // Use the Regex.Matches method to find all matches in the input text
            MatchCollection matches = regex.Matches(inputText);

            // Convert the matches to an array of strings
            string[] emailAddresses = new string[matches.Count];
            for (int i = 0; i < matches.Count; i++)
            {
                emailAddresses[i] = matches[i].Value;
            }
            return emailAddresses;
        }

        public string[] IsMobileValid(String inputText)
        {
            string pattern = @"\b\d{10}\b";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(inputText);
            string[] mobileAddresses = new string[matches.Count];
            for (int i = 0; i < matches.Count; i++)
            {
                mobileAddresses[i] = matches[i].Value;
            }
            return mobileAddresses;
        }
        public string[]  PerformRegexSearch(string inputText, string customRegexPattern)
        {
            Regex regex = new Regex(customRegexPattern);

            // Use the Regex.Matches method to find all matches in the input text
            MatchCollection matches = regex.Matches(inputText);

            // Convert the matches to an array of strings
            string[] customRegexMatches = new string[matches.Count];
            for (int i = 0; i < matches.Count; i++)
            {
                customRegexMatches[i] = matches[i].Value;
            }

            return customRegexMatches;



        }
    }
}

using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] words = { };
            var f = CountWordFrequency(words);
            Console.WriteLine("Empty array : {0} ", f.Count == 0 ? "OK" : "FAILURE");
            string wordsInString = "Add add dictionary new dictionary hello world hello HELLO HeLlO";
            words = wordsInString.Split(' ');
            f = CountWordFrequency(words);
            Console.WriteLine("Not empty array : {0} ", f.Count == 0 ? "OK" : "FAILURE");

            Console.WriteLine("Our words: " + wordsInString);
            foreach (KeyValuePair<string, int> pair in f)
            {
                Console.WriteLine(pair.Key + " " + pair.Value);
            }
        }

        public static Dictionary<string, int> CountWordFrequency(string[] words)
        {
            Dictionary<string, int> wordFrequency = new Dictionary<string, int>();
            foreach (string word in words)
            {
                if (wordFrequency.ContainsKey(word.ToLower()))
                {
                    wordFrequency[word.ToLower()]++;
                }
                else
                {
                    wordFrequency.Add(word.ToLower(), 1);
                }
            }
            return wordFrequency;
        }
    }
}

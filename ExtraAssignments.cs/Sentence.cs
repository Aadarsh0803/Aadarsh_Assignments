using System;
using System.Collections.Generic;

class Sentence
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Please provide a sentence as a command line argument.");
            return;
        }

        string sentence = string.Join(" ", args);
        Dictionary<string, int> wordFrequency = GetWordFrequency(sentence);

        foreach (var item in wordFrequency)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }
    }

    static Dictionary<string, int> GetWordFrequency(string sentence)
    {
        Dictionary<string, int> wordFrequency = new Dictionary<string, int>();
        string[] words = sentence.Split(' ');

        foreach (string word in words)
        {
            string cleanedWord = word.Trim().ToLower();
            if (wordFrequency.ContainsKey(cleanedWord))
            {
                wordFrequency[cleanedWord]++;
            }
            else
            {
                wordFrequency[cleanedWord] = 1;
            }
        }

        return wordFrequency;
    }
}

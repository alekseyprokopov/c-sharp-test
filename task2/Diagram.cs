using System;
using System.Collections.Generic;
using System.Linq;

namespace task2
{
    public class Diagram
    {
        public static void Display(string input)
        {
            if (input == "")
            {
                return;
            }

            var words = input.Split(' ');
            var map = new Dictionary<string, int>();
            var maxLen = 0;
            var maxCount = 0;

            foreach (var word in words)
            {
                maxLen = Math.Max(maxLen, word.Length);

                if (map.ContainsKey(word))
                {
                    map[word]++;
                }
                else
                {
                    map.Add(word, 1);
                }

                maxCount = Math.Max(maxCount, map[word]);
            }

            var orderedWords = map.OrderBy((key => key.Value));

            foreach (var word in orderedWords)
            {
                var dotCount = (int)Math.Round(10 * ((double)word.Value / maxCount));
                var key = string.Concat(Enumerable.Repeat("_", maxLen - word.Key.Length));
                var value = string.Concat(Enumerable.Repeat(".", dotCount));

                Console.WriteLine($"{key + word.Key}: {value}");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace _01.Cards
{
    public class Program
    {
        public static void Main()
        {
            var result = new List<string>();
            var input = Console.ReadLine();
            var pattern = @"([1]*[0-9JQKA])([SHDC])";
            var regex = new Regex(pattern);
            var matches = regex.Matches(input);
            foreach (Match card in matches)
            {
                var power = 0;
                if (int.TryParse(card.Groups[1].Value, out power))
                {
                    if (power < 2 || power > 10)
                    {
                        continue;
                    }
                }
                result.Add(card.Value);
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
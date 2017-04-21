using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace _02.Fish_Statistics
{
    public class Program
    {
        public static void Main()
        {
            var bodyPartsCount = new Dictionary<string, long>(); // count char occurances
            var matchResult = new List<string>(); // add legit fishes here 
            var input = Console.ReadLine();
            var pattern = @"(>*)<(\(+)([\'-]|x)>";
            var regex = new Regex(pattern);
            long tailLenghtSantimeters = 0;
            long bodyLenghtSantimeters = 0;
            var tailType = string.Empty;
            var bodyType = string.Empty;
            var confirmStatus = string.Empty;
            var matches = regex.Matches(input);
            if (matches.Count < 1)
            {
                Console.WriteLine("No fish found.");
            }
            long counter = 0;
            foreach (Match fish in matches)
            {
                counter++;
                matchResult.Add(fish.ToString());
                long tailLenght = fish.Groups[1].Length;
                long bodyLenght = fish.Groups[2].Length;
                var status = fish.Groups[3].ToString();
                tailLenghtSantimeters = tailLenght * 2; //tail to CM
                bodyLenghtSantimeters = bodyLenght * 2;
                if (tailLenghtSantimeters > 10) //tail
                {
                    tailType = "Long";
                }
                else if (tailLenghtSantimeters > 2)
                {
                    tailType = "Medium";
                }
                else if (tailLenghtSantimeters == 2)
                {
                    tailType = "Short";
                }
                else if (tailLenghtSantimeters < 2)
                {
                    tailType = "None";
                }
                if (bodyLenghtSantimeters > 20) //body
                {
                    bodyType = "Long";
                }
                else if (bodyLenghtSantimeters > 10)
                {
                    bodyType = "Medium";
                }
                else if (bodyLenghtSantimeters >= 2 && bodyLenghtSantimeters <= 8)
                {
                    bodyType = "Short";
                }
                if (status == "'") //status
                {
                    confirmStatus = "Awake";
                }
                else if (status == "-")
                {
                    confirmStatus = "Asleep";
                }
                else if (status == "x")
                {
                    confirmStatus = "Dead";
                }
                Console.WriteLine($"Fish {counter}: {fish}");
                if (tailLenghtSantimeters >= 2)
                {
                    Console.WriteLine($"  Tail type: {tailType} ({tailLenghtSantimeters} cm)");
                }
                else
                {
                    Console.WriteLine($"  Tail type: {tailType}");
                }
                Console.WriteLine($"  Body type: {bodyType} ({bodyLenghtSantimeters} cm)");
                Console.WriteLine($"  Status: {confirmStatus}");
            }
        }
    }
}
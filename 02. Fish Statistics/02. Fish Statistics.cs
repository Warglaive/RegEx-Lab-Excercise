using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace _02.Fish_Statistics
{
   public class Program
    {
       public static void Main()
        {
            var bodyPartsCount = new Dictionary<string, int>(); // count char occurances
            var matchResult = new List<string>(); // add legit fishes here 
            var input = Console.ReadLine();
            var pattern = @"([>]*)<*(\(+)(['|x|-])>";
            var regex = new Regex(pattern);
            var tailLenghtSantimeters = 0;
            var tailType = string.Empty;

            var matches = regex.Matches(input);
            foreach (Match fish in matches)
            {
                matchResult.Add(fish.ToString());
                var tailLenght = fish.Groups[1].Length;
                var bodyLenght = fish.Groups[2].Length;
                tailLenghtSantimeters = tailLenght * 2; //tail to CM

                if (tailLenghtSantimeters > 10)
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

            }
        }
    }
}
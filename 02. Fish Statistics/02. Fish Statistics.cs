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
            var pattern = @"[>|<]*<*\(+['|x|-]>";
            var regex = new Regex(pattern);

            var matches = regex.Matches(input);
            foreach (var fish in matches)
            {
                matchResult.Add(fish.ToString());
            }
            foreach (var fish in matchResult)
            {
                foreach (var fishParts in fish)
                {
                    if (fishParts < 5) //use dictionary value to check character's count
                    {

                    }
                }
            }
        }
    }
}
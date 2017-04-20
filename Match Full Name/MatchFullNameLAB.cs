using System;
using System.Text.RegularExpressions;
namespace _01.Match_Full_Name
{
    public class MatchFullNameLAB
    {
       public static void Main()
        {
            var input = Console.ReadLine();
            while (input!="end")
            {
                var pattern= @"<a.+?href=(.+?)>(.+?)<\/a>";
                var regex = new Regex(pattern);
                var replacements = "[URL href=$1]$2[/URL]";
                var result = regex.Replace(input, replacements);
                Console.WriteLine(result);
                input = Console.ReadLine();
            }
        }
    }
}
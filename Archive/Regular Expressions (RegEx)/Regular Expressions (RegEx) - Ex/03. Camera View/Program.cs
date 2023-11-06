using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace _03._Camera_View
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int skip = nums[0];
            int take = nums[1];

            string pattern = "\\|<(\\w{" + skip + "})(\\w{0," + take + "})";//with this you can skip, and then with the 0 before the take word, we  tell it from which index to start taking chars
            string input = Console.ReadLine();
            MatchCollection matchedResult = Regex.Matches(input, pattern);
            List<string> photos = new List<string>();
            foreach (Match match in matchedResult)
            {
                photos.Add(match.Groups[2].Value);
            }
            Console.WriteLine(string.Join(", ", photos));
        }
    }
}

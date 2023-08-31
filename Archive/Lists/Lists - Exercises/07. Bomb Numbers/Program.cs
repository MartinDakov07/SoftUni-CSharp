using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;
using System.Text;
namespace _07._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] bombNumber = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int bomb = bombNumber[0];
            int power = bombNumber[1];
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == bomb)
                {
                    if (power + i >= nums.Count)//this is if we will overflow the list
                    {
                        nums.RemoveRange(i, nums.Count - i);

                        if (i < power)//this is we have less indexes on the left than our power
                        {
                            nums.RemoveRange(0, i);
                        }
                        else
                        {
                            nums.RemoveRange(i - power, power);
                        }
                        i--;
                    }
                    else
                    {
                        nums.RemoveRange(i, power + 1);//+1 because we remove the bomb too
                        if (i < power)
                        {
                            nums.RemoveRange(0, i);
                        }
                        else
                        {
                            nums.RemoveRange(i - power, power);
                        }
                        i--;

                    }
                }
            }
            Console.WriteLine(nums.Sum());

        }
    }
}

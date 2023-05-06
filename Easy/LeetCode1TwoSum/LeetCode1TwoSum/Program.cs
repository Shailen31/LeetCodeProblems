using System;
using System.Globalization;

namespace LeetCode1TwoSum
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] nums = { 2, 7, 11, 15 };
      int target = 17;
      int[] targetNums = TwoSum(nums, target);

      foreach (int num in targetNums)
      {
        Console.WriteLine(num);
      }
    }

    public static int[] TwoSum(int[] nums, int target)
    {
      for (int i = 0; i < nums.Length; i ++ )
      {
        for (int j = i + 1; j < nums.Length; j ++)
        {
          if (nums[i] + nums[j] == target )
          {
            return new[] { i, j };
          }
        }
      }

      return null;
    }

  }
}

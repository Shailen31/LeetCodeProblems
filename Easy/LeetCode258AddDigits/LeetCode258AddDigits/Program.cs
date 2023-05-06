using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace LeetCode258AddDigits
{
  public class Program
  {
    static void Main(string[] args)
    {
      int x = AddDigits(38);

      Console.WriteLine(x);
      Console.ReadLine();
    }

    public static int AddDigits(int num)
    {
      int workingNum = num;

      while (workingNum.ToString().Count() > 1)
      {
        List<int> numList = new List<int>();
        numList = SplitNumber(workingNum);
        workingNum = AddNums(numList);
      }

      return workingNum;
    }

    public static int AddNums(List<int> numList)
    {
      int sum = 0;
      foreach (int num in numList)
      {
        sum += num;
      }
      return sum;
    }

    public static List<int> SplitNumber(int num)
    {
      List<int> numbers = new List<int>();
      string strNum = num.ToString();
      char[] splitNumbers = strNum.ToCharArray();

      foreach (char chr in splitNumbers)
      {
        Console.WriteLine("this is the numbers " + (int)char.GetNumericValue(chr));
        numbers.Add((int)char.GetNumericValue(chr));
      }

      return numbers;
    }
  }
}

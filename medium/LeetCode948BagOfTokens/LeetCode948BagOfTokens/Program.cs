using System;

namespace LeetCode948BagOfTokens
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }
  
    public int BagOfTokensScore(int[] tokens, int power) 
    {
      int score = 0; 

      for (int i = 0; i <tokens.Length; i ++)
      {
        if (tokens[i] != -1)
        {
          if (power >= tokens[i])
          {
            tokens = playToken(tokens, i);
          }
        }
        
      }
      
    }


    public int[] playToken(int[] tokens, int index )
    {
      tokens[index] = -1;
      
      return tokens;
    }
  }
}

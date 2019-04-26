using System;
using System.Collections.Generic;

namespace Wordcount.Models
{
  public class Counter
  {
      private static char[] _letters = "qwertyuiopasdfghjklzxcvbnm".ToCharArray();
      private string _compare;
      private string _comparedTo;

      public Counter(string com, string to)
      {
        _compare = com;
        _comparedTo = to;
      }

      public int Count()
      {
        int count = 0;
        char[] compare = _compare.ToLower().ToCharArray();
        char[] to = _comparedTo.ToLower().ToCharArray();
        foreach(char letter in compare)
        {
          if(Array.IndexOf(Counter._letters,letter) < 0)
          {
            return count;
          }
        }
        for(int i = 0; i < to.Length; i++)
          {
            if(to[i] == compare[0])
            {
              int toIgnore = 0;
              for(int j = 0;j-toIgnore<compare.Length;j++)
              {
                if(i+j > to.Length-1)
                {
                  break;
                }
                if(Array.IndexOf(_letters, to[i+j]) < 0)
                {
                  toIgnore++;
                }else
                {
                  if(to[i+j] != compare[j-toIgnore])
                  {
                    break;
                  }
                }
                if(j-toIgnore == compare.Length-1)
                {
                  count++;
                }
              }
            }
          }
        return count;
      }
  }
}

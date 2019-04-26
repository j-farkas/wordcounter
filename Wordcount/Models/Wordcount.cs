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
              int startCheck = 1;
              int ignored = 0;
              while(startCheck > 0)
              {
                if(startCheck >= compare.Length-1)
                {
                  count++;
                  startCheck = 0;
                }else
                {
                  if(Array.IndexOf(Counter._letters, to[i+startCheck+ignored]) < 0)
                  {
                    ignored++;
                    if(startCheck+ignored + i > to.Length)
                    {
                      break;
                    }
                  }else
                  {
                    if(to[i+startCheck + ignored] == to[startCheck + ignored])
                    {
                      startCheck++;
                    }else
                    {
                      break;
                    }
                  }
                }
              }

            }
          }

        return count;
      }
  }
}

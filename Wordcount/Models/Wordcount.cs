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

        char[] compare = _compare.ToCharArray();
        char[] to = _comparedTo.ToCharArray();

        for(int i = 0; i < to.Length; i++)
          {
            if(to[i] == compare[0])
            {
              int startCheck = 1;
              while(startCheck > 0)
              {
                if(startCheck >= compare.Length-1)
                {
                  count++;
                  startCheck = 0;
                }else
                {
                  if(to[i+startCheck] == to[startCheck])
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

        return count;
      }
  }
}

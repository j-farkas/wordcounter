using System;
using System.Collections.Generic;

namespace Wordcount.Models
{
  public class Counter
  {
      private static char[] _letters = "qwertyuiopasdfghjklzxcvbnm".ToCharArray();
      private string _compare;
      private string _comparedTo;
      private int _id;
      private static List<Counter> _instances = new List<Counter> {};

      public Counter(string com, string to)
      {
        _compare = com;
        _comparedTo = to;
        _instances.Add(this);
        _id = _instances.Count;
      }

      public static void DeleteAt(int index)
      {
        _instances.RemoveAt(index);
        foreach(Counter counter in _instances)
        {
          if(index < counter._id)
          {
            counter._id--;
          }
        }
      }

      public static List<Counter> GetAll()
      {
        return _instances;
      }

      public static void ClearAll()
      {
        _instances = new List<Counter>{};
      }

      public static Counter Find(int searchId)
      {
        return _instances[searchId-1];
      }
      public string GetCompare()
      {
        return _compare;
      }

      public void SetCompare(string com)
      {
        _compare = com;
      }

      public string GetTo()
      {
        return _comparedTo;
      }

      public int GetId()
      {
        return _id;
      }

      public void SetTo(string to)
      {
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

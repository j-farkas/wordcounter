using System;
using System.Collections.Generic;

namespace Wordcount.Models
{
  public class ScrabbleScore
  {
    private static char[] One = "aeioulnrst".ToCharArray();
    private static char[] Two = "dg".ToCharArray();
    private static char[] Three = "bcmp".ToCharArray();
    private static char[] Four = "fhvwy".ToCharArray();
    private static char[] Five = "k".ToCharArray();
    private static char[] Eight = "jx".ToCharArray();
    private static char[] Ten = "qz".ToCharArray();

    public static int ScoreIt(string theWord)
    {
      int score = 0;
      theWord = theWord.ToLower();
      char[] toScore = theWord.ToCharArray();
      for (int i = 0; i < toScore.Length; i++) {
          if(Array.IndexOf(One,toScore[i])>=0)
          {
            score++;
          }
          if(Array.IndexOf(Two,toScore[i])>=0)
          {
            score+=2;
          }
          if(Array.IndexOf(Three,toScore[i])>=0)
          {
            score+=3;
          }
          if(Array.IndexOf(Four,toScore[i])>=0)
          {
            score+=4;
          }
          if(Array.IndexOf(Five,toScore[i])>=0)
          {
            score+=5;
          }
          if(Array.IndexOf(Eight,toScore[i])>=0)
          {
            score+=8;
          }
          if(Array.IndexOf(Ten,toScore[i])>=0)
          {
            score+=10;
          }
      }
      return score;
    }
  }
}

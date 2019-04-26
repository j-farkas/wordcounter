using System;
using System.Collections.Generic;
using System.Linq;

namespace Sorting.Models
{
  public class SortingMethods
  {
    public static int[] BubbleSort(int[] ToSort)
    {
      bool IsSorted = false;
      int Sorted = 1;
      while (IsSorted == false)
      {
        IsSorted = true;
        for (int i = 0; i < ToSort.Length - Sorted; i++)
        {
          if (ToSort[i] > ToSort[i+1])
          {
            int Temp = ToSort[i+1];
            ToSort[i+1] = ToSort[i];
            ToSort[i] = Temp;
            IsSorted = false;
          }
        }
        Sorted ++;
      }
      return ToSort;
    }
    public static int[] InsertionSort(int[] ToSort)
    {
      for (int i = 1; i < ToSort.Length; i++)
      {
        int j = i;
        while(j > 0)
        {
          if(ToSort[j-1] > ToSort[j])
          {
              int Temp = ToSort[j-1];
               ToSort[j-1] = ToSort[j];
               ToSort[j] = Temp;
               j--;
          }else{
            break;
          }
        }
      }
      return ToSort;
    }
    public static int[] MergeSort(int[] ToSort)
    {

      // int[] firstHalf = ToSort.Take(ToSort.Length / 2 + ToSort.Length % 2).toArray();
      // int[] secondHalf = ToSort.Skip(ToSort.Length / 2).toArray();

      int[] firstHalf = new int[ToSort.Length / 2 + ToSort.Length % 2];
      int[] secondHalf = new int[ToSort.Length / 2];
      int place = 0;
      for(int i = 0; i < ToSort.Length; i++)
      {
        if(i < ToSort.Length / 2 + ToSort.Length % 2){
          firstHalf[place] = ToSort[i];
        }else if(i == ToSort.Length / 2 + ToSort.Length % 2){
          place = 0;
          secondHalf[place] = ToSort[i];
        }else{
          secondHalf[place] = ToSort[i];
        }
        place++;
      }

      if(firstHalf.Length > 3)
      {
        firstHalf = SortingMethods.MergeSort(firstHalf);
      }else{
        firstHalf = SortingMethods.InsertionSort(firstHalf);
      }

      if(secondHalf.Length > 2)
      {
        secondHalf = SortingMethods.MergeSort(secondHalf);
      }else{
        secondHalf = SortingMethods.InsertionSort(secondHalf);
      }

      int[] wholeArr = new int[ToSort.Length];
      place = 0;
      for(int i = 0; i < firstHalf.Length; i++)
      {
        wholeArr[place] = firstHalf[i];
        place++;
      }
      for(int i = 0; i < secondHalf.Length; i++)
      {
        wholeArr[place] = secondHalf[i];
        place++;
      }
      wholeArr = SortingMethods.InsertionSort(wholeArr);

      return wholeArr;
      }
    }
  }

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sorting.Models;
using System;
using System.Collections.Generic;

namespace Sorting.TestTools
{
  [TestClass]
  public class SortingTests
  {
    [TestMethod]
    public void CheckIsSorted_BubbleSortsArray_True()
    {
      int[] num = new int[] {4, 3, 1, 2};
      int[] num2 = SortingMethods.BubbleSort(num);
      Assert.AreEqual(3, num2[2]);
    }
    [TestMethod]
    public void CheckIsSorted_InsertionSortsArray_True()
    {
      int[] num = new int[] {4, 3, 1, 2, 0};
      int[] num2 = SortingMethods.InsertionSort(num);
      Assert.AreEqual(0, num2[0]);
    }

    [TestMethod]
    public void CheckIsSorted_MergeSortsArray_True()
    {
      int[] num = new int[] {4, 3, 1, 2, 0, 77, 99, 27381, 28, 921873, 2487, 4239, 92, 11, 93, 111};
      int[] num2 = SortingMethods.MergeSort(num);
      Assert.AreEqual(4, num2[8]);
    }
  }
}

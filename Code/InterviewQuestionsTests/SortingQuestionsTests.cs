using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewQuestions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterviewQuestionsTests
{
    [TestClass]
    public class SortingQuestionsTests
    {
        [TestMethod]
        public void BubbleSortTest()
        {
            int[] input = { 5, 0, 4, 9, 0, -1, -9 };
            SortingQuestions.BubbleSort(input);
            Assert.IsTrue(ArrayEquals(new[] {-9, -1, 0, 0, 4, 5, 9}, input));
        }

        [TestMethod]
        public void SelectionSortTest()
        {
            int[] input = { 5, 0, 4, 9, 0, -1, -9 };
            SortingQuestions.SelectionSort(input);
            Assert.IsTrue(ArrayEquals(new[] {-9, -1, 0, 0, 4, 5, 9}, input));
        }

        [TestMethod]
        public void InsertionSortTest()
        {
            int[] input = { 5, 0, 4, 9, 0, -1, -9 };
            SortingQuestions.InsertionSort(input);
            Assert.IsTrue(ArrayEquals(new[] { -9, -1, 0, 0, 4, 5, 9 }, input));
        }

        [TestMethod]
        public void QuickSortTest()
        {
            int[] input = { 5, 0, 4, 9, 0, -1, -9 };
            SortingQuestions.QuickSort(input);
            Assert.IsTrue(ArrayEquals(new[] { -9, -1, 0, 0, 4, 5, 9 }, input));
        }

        private bool ArrayEquals(int[] a, int[] b)
        {
            if (a.Length != b.Length) return false;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i]) return false;
            }

            return true;
        }
    }
}

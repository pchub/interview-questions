using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewQuestions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterviewQuestionsTests
{
    [TestClass]
    public class ArrayQuestionsTests
    {
        [TestMethod]
        public void MergeArraysBasicTest()
        {
            int[] a = { 1, 3, 5, 7 };
            int[] b = { -1, 0, 4, 6, 10 };
            var c = ArrayQuestions.MergeArrays(a, b);
            Assert.IsTrue(ArrayEquals(new[] { -1, 0, 1, 3, 4, 5, 6, 7, 10 }, c));

        }

        [TestMethod]
        public void MergeMultipleArraysBasicTest()
        {
            int[] a = { 1, 3, 5, 7 };
            int[] b = { -1, 0, 4, 6, 10 };
            var c = ArrayQuestions.MergeMultipleArrays(new List<int[]>{a, b});
            Assert.IsTrue(ArrayEquals(new[] { -1, 0, 1, 3, 4, 5, 6, 7, 10 }, c));
        }

        [TestMethod]
        public void PartitionTest()
        {
            int[] input = {4, 1, 9, 0, -1, 6, 5};
            var pivotIndex = ArrayQuestions.Partition(input, 0);
            Assert.AreEqual(3, pivotIndex);
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

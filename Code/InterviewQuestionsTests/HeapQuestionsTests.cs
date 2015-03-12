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
    public class HeapQuestionsTests
    {
        [TestMethod]
        public void HeapSizeTest()
        {
            var heap = new MaxHeap<int>();
            Assert.AreEqual(0, heap.Size);
            heap.Add(new HeapNode<int>(1, 999) );
            Assert.AreEqual(1, heap.Size);
        }

        [TestMethod]
        public void HeapMaxTest()
        {
            var heap = new MaxHeap<int>();
            Assert.IsNull(heap.Max);
            heap.Add(new HeapNode<int>(2, 999));
            Assert.AreEqual(2, heap.Max.Key);
            heap.Add(new HeapNode<int>(3, 998));
            Assert.AreEqual(3, heap.Max.Key);
            heap.Add(new HeapNode<int>(1, 997));
            Assert.AreEqual(3, heap.Max.Key);
        }

        [TestMethod]
        public void AddRemoveTest()
        {
            int max = 99999;
            var heap = new MaxHeap<int>();
            for (int i = max; i > 0; i--)
            {
                heap.Add(new HeapNode<int>(i, 0));
            }

            Assert.AreEqual(max, heap.Size);
            Assert.AreEqual(max, heap.Max.Key);

            for (int i = max; i > 0; i--)
            {
                var item = heap.Remove();
                Assert.AreEqual(i, item.Key);
            }
        }
    }
}

using System;
using InterviewQuestions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterviewQuestionsTests
{
    [TestClass]
    public class LinkedListQuestionsTests
    {
        [TestMethod]
        public void LinkedListReverseBasicTest()
        {
            var list = new LinkedList<int>();
            list.Add(5);
            list.Add(6);
            list.Add(7);
            Assert.AreEqual(7, list.Head.Data);

            var reversedList = LinkedListQuestions.ReverseLinkedList(list);

            Assert.AreEqual(5, reversedList.Head.Data);
            Assert.AreEqual(6, reversedList.Head.Next.Data);
            Assert.AreEqual(7, reversedList.Head.Next.Next.Data);
            Assert.AreEqual(null, reversedList.Head.Next.Next.Next);
        }

        [ExpectedException(typeof(ArgumentNullException))]
        [TestMethod]
        public void LinkedListReverseNullInputTest()
        {
            LinkedListQuestions.ReverseLinkedList<int>(null);
        }

        [TestMethod]
        public void LinkedListReverseEmptyLinkedListTest()
        {
            var list = new LinkedList<int>();
            var reversedList = LinkedListQuestions.ReverseLinkedList(list);
            Assert.AreEqual(null, reversedList.Head);
        }

        [TestMethod]
        public void LinkedListReverseLongListTest()
        {
            var list = new LinkedList<int>();

            for (int i = 0; i < 100; i++)
            {
                list.Add(i);
            }

            var reversedList = LinkedListQuestions.ReverseLinkedList(list);

            for (int i = 0; i < 100; i++)
            {
                var head = reversedList.RemoveHead();
                Assert.AreEqual(i, head.Data);
            }
        }

        [TestMethod]
        public void LinkedListNthToLastBasicTest()
        {
            var list = new LinkedList<int>();

            for (int i = 0; i < 100; i++)
            {
                list.Add(i);
            }

            for (int i = 1; i < 100; i++)
            {
                var nthToLastNode = LinkedListQuestions.FindNthToLastNode(list, i);
                Assert.AreEqual(i - 1, nthToLastNode.Data);
            }
        }
    }
}

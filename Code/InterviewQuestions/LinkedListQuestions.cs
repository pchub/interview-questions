using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    public class LinkedListNode<T>
    {
        public T Data { get; set; }

        public LinkedListNode<T> Next { get; set; }
    }

    public class LinkedList<T>
    {
        public LinkedListNode<T> Head { get; set; }

        public void Add(T data)
        {
            this.Add(new LinkedListNode<T>() { Data = data });
        }

        public void Add(LinkedListNode<T> node)
        {
            node.Next = this.Head;
            this.Head = node;
        }

        public LinkedListNode<T> RemoveHead()
        {
            if (this.Head == null) return null;

            var returnValue = this.Head;
            this.Head = this.Head.Next;

            return returnValue;
        }

    }

    public class LinkedListQuestions
    {
        public static LinkedList<T> ReverseLinkedList<T>(LinkedList<T> list)
        {
            if (list == null) throw new ArgumentNullException("list");

            LinkedListNode<T> current = list.Head;
            LinkedListNode<T> previous = null;
            while (true)
            {
                if (current == null) break;
                var next = current.Next;
                current.Next = previous;
                previous = current;
                current = next;
            }

            list.Head = previous;
            return list;
        }

        public static LinkedListNode<T> FindNthToLastNode<T>(LinkedList<T> list, int n)
        {
            if (list == null) throw new ArgumentNullException("list");

            if(n < 1) throw new ArgumentOutOfRangeException("n should be greated than or equal to 1.");

            LinkedListNode<T> frontRunner = list.Head;
            for (int i = 0; i < n; i++)
            {
                if (frontRunner == null) return null;
                frontRunner = frontRunner.Next;
            }

            var backRunner = list.Head;
            while (frontRunner != null)
            {
                backRunner = backRunner.Next;
                frontRunner = frontRunner.Next;
            }

            return backRunner;
        }
    }
}

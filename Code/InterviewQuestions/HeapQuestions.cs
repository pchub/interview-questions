using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    public class HeapNode<T>
    {
        public HeapNode(int key, T data)
        {
            this.Key = key;
            this.Data = data;
        }

        public int Key { get; private set; }

        public T Data { get; private set; }
    }

    public class MaxHeap<T>
    {
        readonly List<HeapNode<T>> _internalStorage = new List<HeapNode<T>>();

        public HeapNode<T> Max
        {
            get
            {
                return this._internalStorage.Count == 0 ? null : this._internalStorage[0];
            }
        }

        public int Size
        {
            get { return this._internalStorage.Count; }
        }

        public void Add(HeapNode<T> node)
        {
            this._internalStorage.Add(node);
            PercolateUp(this.Size - 1);
        }

        public HeapNode<T> Remove()
        {
            if (this.Size == 0) return null;
            var max = this._internalStorage[0];
            this._internalStorage[0] = this._internalStorage[this._internalStorage.Count - 1];
            this._internalStorage.RemoveAt(this._internalStorage.Count - 1);

            if (this.Size > 0)
            {
                this.PercolateDown(0);
            }

            return max;
        }

        private int LeftChild(int i)
        {
            int left = (2 * i) + 1;
            if (left >= this._internalStorage.Count) return -1;
            return left;
        }

        private int RightChild(int i)
        {
            int right = (2 * i) + 2;
            if (right >= this._internalStorage.Count) return -1;
            return right;
        }

        private int Parent(int i)
        {
            if (i == 0) return -1;
            int parent = (i - 1) / 2;
            return parent;
        }

        private void PercolateDown(int i)
        {
            var leftIndex = this.LeftChild(i);
            var rightIndex = this.RightChild(i);
            var current = this._internalStorage[i];

            // No left or right children
            if (leftIndex == -1 && rightIndex == -1) return;

            int max = i;

            if (leftIndex == -1)
            {
                max = rightIndex;
            }
            else if (rightIndex == -1)
            {
                max = leftIndex;
            }
            else if (this._internalStorage[leftIndex].Key > this._internalStorage[rightIndex].Key)
            {
                max = leftIndex;
            }
            else if (this._internalStorage[leftIndex].Key < this._internalStorage[rightIndex].Key)
            {
                max = rightIndex;
            }

            if (i != max && this._internalStorage[max].Key > this._internalStorage[i].Key)
            {
                Swap(i, max);
                PercolateDown(max);
            }
        }

        private void PercolateUp(int i)
        {
            int parent = this.Parent(i);
            if (parent == -1) return;

            if (this._internalStorage[i].Key > this._internalStorage[parent].Key)
            {
                Swap(i, parent);
                PercolateUp(parent);
            }
        }

        private void Swap(int i, int j)
        {
            var temp = this._internalStorage[i];
            this._internalStorage[i] = this._internalStorage[j];
            this._internalStorage[j] = temp;
        }
    }

    class HeapQuestions
    {
    }
}

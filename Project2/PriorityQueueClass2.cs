using System;
using System.Collections.Generic;

namespace Project2
{
    internal class PriorityQueueClass2
    {
        List<int> list;
        public PriorityQueueClass2()
        {
            list = new List<int>();
        }

        public void Enqueue(int item)
        {
            list.Add(item);
        }
        public int Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty.");
            }
            int minIndex = 0;
            int i = 1;
            while (i < list.Count)
            {
                if (list[i] < list[minIndex])
                {
                    minIndex = i;
                }
                i++;
            }
            int minElement=list[minIndex];
            list.RemoveAt(minIndex);
            return minElement;
        }
        public bool IsEmpty()
        {
            return Count() == 0;
        }
        public int Count()
        {
            return list.Count;
        }
    }
}

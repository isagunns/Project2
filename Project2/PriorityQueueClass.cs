using System;
using System.Collections.Generic;

namespace Project2
{
    class EgeDeniziBNameComparer : IComparer<EgeDeniziB>
    {
        public int Compare(EgeDeniziB item1, EgeDeniziB item2)
        {
            return string.Compare(item1.name, item2.name, StringComparison.Ordinal);
        }
    }

    class PriorityQueueClass
    {
        List<EgeDeniziB> pq;
        public PriorityQueueClass()
        {
            pq = new List<EgeDeniziB>();
        }

        public void Enqueue(EgeDeniziB element)
        {
            pq.Add(element);
        }
        public EgeDeniziB Dequeue()
        {

            if (IsEmpty())
            {
                return null;
            }
            EgeDeniziBNameComparer comparer = new EgeDeniziBNameComparer();

            EgeDeniziB minElement = pq[0];
            int minIndex = 0;
            int i = 1;
            while (i < pq.Count)
            {
                if (comparer.Compare(pq[i], minElement) < 0)//1. eleman 2. elemandan daha küçükse yani alfabetik olarak önce geliyorsa
                {
                    minElement = pq[i];
                    minIndex = i;
                }
                i++;
            }
            pq.RemoveAt(minIndex);
            return minElement;
        }
        public bool IsEmpty()
        {
            return pq.Count == 0;
        }
    }
}
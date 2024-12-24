using System;

namespace Poject2
{
    class QueueClass<T>
    {
        private T[] queueArray;
        private int front;
        private int rear;
        private int maxSize;
        private int count;
        public QueueClass(int size)
        {
            maxSize = size;
            queueArray = new T[maxSize];
            front = 0;
            rear = -1;
            count = 0;
        }
        public void Enqueue(T item)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue is full.");
                return;
            }

            rear++;
            queueArray[rear] = item;
            count++;
        }
        public T Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty.");
            }
            T temp = queueArray[front];
            front++;
            count--;
            return temp;
        }

        public bool IsEmpty()
        {
            return count == 0;
        }
        public bool IsFull()
        {
            return count == maxSize;
        }
        public int Size()
        {
            return count;
        }
        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty.");
            }
            return queueArray[front];
        }
    }

}


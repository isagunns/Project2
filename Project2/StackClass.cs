using System;

namespace Project2
{
    class StackClass<T>
    {
        private T[] stackArray;
        private int top;
        private int capacity;

        public StackClass(int size)
        {
            capacity = size;
            stackArray = new T[capacity];
            top = -1; 
        }

        public void Push(T item)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack is full!");
                return;
            }
            stackArray[++top] = item;
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty!");
            }
            return stackArray[top--];
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty! Cannot peek.");
            }
            return stackArray[top];
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public bool IsFull()
        {
            return top == capacity - 1;
        }

        public int Size()
        {
            return top + 1;
        }
    }
}

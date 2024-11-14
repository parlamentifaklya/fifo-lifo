using System;

namespace fifo_lifo
{
    public class LIFO
    {
        private double[] array;
        private int stackPointer;

        public LIFO()
        {
            stackPointer = 0;
            array = new double[50];
        }

        public LIFO(int size)
        {
            stackPointer = 0;
            array = new double[size];
        }

        public void Push(double element)
        {
            if (stackPointer < array.Length)
            {
                array[stackPointer++] = element;
            }
            else
            {
                throw new StackOverflowException("Stack overflow!");
            }
        }

        public double Pop()
        {
            if (stackPointer == 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            else
            {
                return array[--stackPointer];
            }
        }

        public void Clear()
        {
            stackPointer = 0;
        }

        public int Length()
        {
            return stackPointer;
        }

        public int GetSize()
        {
            return array.Length;
        }
    }
}
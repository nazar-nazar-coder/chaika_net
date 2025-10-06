using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.lab2
{
    internal class Arrays
    {
        private int[] arr;
        private int size;
        private static Random rand = new Random();

        public int Size
        {
            get => size;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Розмір масиву має бути більше 0");
                size = value;
                arr = new int[size];
            }
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= size)
                    throw new IndexOutOfRangeException("Індекс поза межами масиву");
                return arr[index];
            }
            set
            {
                if (index < 0 || index >= size)
                    throw new IndexOutOfRangeException("Індекс поза межами масиву");
                arr[index] = value;
            }
        }

        public Arrays() : this(10) { }

        public Arrays(int n)
        {
            Size = n;
            FillRandom();
        }

        public void FillRandom(int min = -100, int max = 100)
        {
            for (int i = 0; i < size; i++)
                arr[i] = rand.Next(min, max + 1);
        }

        public bool IsDescending()
        {
            for (int i = 0; i < size - 1; i++)
                if (arr[i] < arr[i + 1])
                    return false;
            return true;
        }

        public string ToStr()
        {
            return string.Join(", ", arr);
        }
    }
}

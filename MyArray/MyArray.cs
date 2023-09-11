using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;
using System.Windows.Markup;
using System.Xml.Linq;

namespace MyArrays
{
    internal class MyArray
    {
        private int size;
        private int[] array;
        private int available;
        private bool full;

        public MyArray(int size) 
        {
            this.size = size;
            this.array = new int[size];
            this.available = 0;
            for (int i = 0; i < size; i++)
            {
                this.array[i] = -1;            
            }
            this.full = false;
        }
        public MyArray(MyArray other)
        {
            this.size = other.size;
            this.array = other.array;
            this.available = other.available;
            this.full = other.full;
        }
        public int GetSize() => size;
        public bool IsFull() => full;
        public int IsAvailable() => available < size && array[available] == -1 ? available : -1;
        public int IsAvailable(int index) => index < size && array[index] == -1 ? index : -1;
        public int Count(int value)
        {
            int count = 0;
            foreach (int num in array)
            {
                if (num == value) count++;
            }
            return count;
        }
        public void AddValue(int value)
        {
            int index = IsAvailable();
            if (index >= 0 && index < size)
            {
                array[index] = value;
                available++;
            }
        }
        public void Remove(int value)
        {
            for (int i = 0; i < size; i++)
            {
                if (array[i] == value)
                {
                    array[i] = -1;
                    available--;
                }
            }
        }
        public override string ToString()
        {
            string s = "";
            s += $"Size: {size},avai{available} ,Available Cells: {size - available}, %Available Cells: %{GetPercent()}";
            return s;
        }
        private double GetPercent()
        {
            double percent = ((double)size - (double)available) / (double)size * 100;
            return percent;
        }
        public string PrintArray()
        {
            string s = "[";
            for (int i = 0; i < size; i++)
            {
                if (i == size - 1)
                {
                    s += $"{array[i]} ";
                }
                s += $"{array[i]}, ";
            }
            s += ']';
            Console.WriteLine(s);
            return s;
        }
        public int Max2()
        {
            int max = 0;
            int max2 = 0;
            foreach (int value in array)
            {
                if (max < value)
                {
                    max2 = max;
                    max = value;
                }
            }
            return max2;
        }
        public int ArraySum()
        {
            int sum = 0;
            foreach (int value in array)
            {
                sum += value;
            }
            return sum;
        }
        public int CountDigit(int digit)
        {
            if (digit > 9 || digit < 0)
            {
                return -1;
            }
            int count = 0;
            foreach (int value in array)
            {
                foreach (char digits in value.ToString())
                {
                    if (digits.ToString() == digit.ToString())
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }

}

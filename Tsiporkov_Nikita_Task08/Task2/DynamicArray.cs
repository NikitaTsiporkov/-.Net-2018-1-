using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    class DynamicArray<T> : IEnumerable where T : IComparable, new()
    {
        private int length;
        private T[] array;

        public int Capacity
        {
            get
            {
                return array.Length;
            }
        }

        public void Sort()
        {
            T temp;
            for (int i = 0; i < length; i++)
                for (int j = i; j < length; j++)
                {
                    if (array[i].CompareTo(array[j]) > 0)
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
        }

        public int Length
        {
            get
            {
                return length;
            }
        }

        public DynamicArray()
        {
            array = new T[8];
            length = 0;
        }

        public DynamicArray(int capacity)
        {
            array = new T[capacity];
            length = 0;
        }

        public DynamicArray(T[] input)
        {
            if (input == null)
            {
                throw new ArgumentException("Invalid array");
            }
            length = input.Length;
            array = input;
        }

        public DynamicArray( IEnumerable<T> enumerable)
        {
            if (enumerable == null)
            {
                throw new ArgumentException("Invalid array");
            }
            array = enumerable.ToArray();
            length = array.Length;
        }

        public void Add(T temp)
        {
            if (Capacity == length)
            {
                ReSize(2);
            }
            Insert(temp, length);
        }

        public void AddRange(T[] input)
        {
            if ((length + input.Length) > Capacity)
            {
                int k = ((length + input.Length) / Capacity) + 1;
                ReSize(k);
            }
            input.CopyTo(array, length);
            length = length + input.Length;
        }

        public bool Remove(T input)
        {
            int index = Array.IndexOf(array, input);
            if (index == -1)
            {
                return false;
            }
            for (int i = index; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            length--;
            array[length] = default(T);
            return true;
        }

        public void RemoveAt(int index)
        {
            IsValidIndex(index);
            T[] tmpArr = new T[length - index];
            Array.ConstrainedCopy(array, index + 1, tmpArr, 0, length - index);
            tmpArr.CopyTo(array, index);
            length--;
        }

        public void Insert(T input, int index)
        {
            IsValidIndex(index);
            if ((length + 1) > Capacity)
            {
                ReSize(2);
            }
            T[] tmpArr = new T[length - index];
            Array.ConstrainedCopy(array, index, tmpArr, 0, length - index);
            array[index] = input;
            tmpArr.CopyTo(array, index + 1);
            length++;
        }

        public T this[int index]
        {
            get
            {
                IsValidIndex(index);
                {
                    return array[index];
                }
            }
            set
            {
                IsValidIndex(index);
                {
                    array[index] = value;
                }
            }
        }

        private T[] ReSize(int Coef)
        {
            int capacity = Capacity * Coef;
            T[] tempArr = new T[capacity];
            array.CopyTo(tempArr, 0);
            array = new T[capacity];
            tempArr.CopyTo(array, 0);
            return array;
        }

        private void IsValidIndex(int index)
        {
            if (index > length || index < 0)
            {
                throw new ArgumentException("Invalid index");
            }
        }

        public IEnumerator GetEnumerator()
        {
            return new DynamicArrayNumerator<T>(this);
        }
    }
}
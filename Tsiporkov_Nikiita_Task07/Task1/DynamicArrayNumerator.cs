﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class DynamicArrayNumerator<T> : IEnumerator where T : IComparable, new()
    {
        private int position = -1;
        private DynamicArray<T> array = new DynamicArray<T>();

        public DynamicArrayNumerator(DynamicArray<T> array)
        {
            this.array = array;
        }

        public bool MoveNext()
        {
            if (position < array.Length - 1)
            {
                position++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            position = -1;
        }

        public object Current
        {
            get
            {
                return array[position];
            }
        }
    }
}

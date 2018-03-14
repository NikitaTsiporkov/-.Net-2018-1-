using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class MyString
    {
        private char[] text;
        public MyString()
        { }
        public MyString(string inputText)
        {
            text = inputText.ToCharArray();
        }

        public static MyString operator +(MyString a, MyString b)
        {
            var result = a.ToString() + b.ToString();
            return new MyString(result);
        }
        public static MyString operator -(MyString a, MyString b)
        {
            MyString c = new MyString();
            string inputA, inputB,inputC;
            inputA = a.ToString();
            inputB = b.ToString();
            inputC = inputA.Replace(inputB,string.Empty);
            return new MyString(inputC);
        }
        public static bool operator ==(MyString a, MyString b)
        { 
            string inputA = a.ToString();
            string inputB = b.ToString();
            int cmp = string.Compare(inputA, inputB);
            return cmp == 0;
        }
        public static bool operator !=(MyString a, MyString b)
        {
            return !(a == b);
        }

        public override string ToString()
        {
            string output = new string(text);
            return output;
        }
        public override bool Equals(object obj)
        {
            var str = obj as MyString;
            if (str != null)
            {
                return str == this;
            }

            return false;
        }
    }
}

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
            Text = inputText.ToCharArray();
        }
        public char[] Text
        {
            get
            {
                return text;
            }
            set
            {
                text = new char[value.Length];
                for (int i = 0; i < value.Length; i++)
                {
                    text[i] = value[i];
                }
            }
        }
        public static MyString operator +(MyString a, MyString b)
        {
            MyString c = new MyString();
            List<char> list = new List<char>();
            list.AddRange(a.Text);
            list.AddRange(b.Text);
            c.Text = list.ToArray();
            return c;
        }
        public static MyString operator -(MyString a, MyString b)
        {
            MyString c = new MyString();
            string inputA, inputB,inputC;
            inputA = new string(a.Text);
            inputB = new string(b.Text);
            inputC = inputA.Replace(inputB,"");
            c.Text = inputC.ToCharArray();
            return c;
        }
        public static bool operator ==(MyString a, MyString b)
        {
            bool result;
            string inputA = new string(a.Text);
            string inputB = new string(b.Text);
            int cmp = string.Compare(inputA, inputB);
            if (cmp == 0)
            {
                result = true;
            }
            else 
            {
                result = false;
            }
            return result;
        }
        public static bool operator !=(MyString a, MyString b)
        {
            bool result;
            string inputA = new string(a.Text);
            string inputB = new string(b.Text);
            int cmp = string.Compare(inputA, inputB);
            if (cmp == 0)
            {
                result = false;
            }
            else
            {
                result = true;
            }
            return result;
        }
        public override string ToString()
        {
            string output = new string(Text);
            return output;
        }
    }
}

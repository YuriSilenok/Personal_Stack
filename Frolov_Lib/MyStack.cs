using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Frolov_Lib
{
    public class MyStack<T>
    {
        private class Element
        {
            public T Data { set; get; }
            public Element Next { set; get; }

            public Element()
            {
            }
            public Element(T a)
            {
                Data = a;
                Next = null;
            }
        }

        Element Head = null;

        public void Push(T a)
        {
            Element tmp = new Element(a);

            if (Head == null)
            {
                Head = tmp;
            }
            else
            {
                tmp.Next = Head;
                Head = tmp;
            }
        }

        public T Top()
        {
            if (Head == null)
            {
                throw new Exception("Стек пуст");
            }
            else
            {
                return Head.Data;
            }
        }

        public T Pop()
        {


            T result = Top();
            Head = Head.Next;
            return result;

        }

        public int Count()
        {
            int count = 0;


            Element tmp = Head;
            for (; tmp != null; tmp = tmp.Next)
                count++;

            return count;
        }

        public override string ToString()
        {
            string s = "";

            Element tmp = Head;
            for (; tmp != null; tmp = tmp.Next)
                s += tmp.Data + "\n";

            return s;
        }



    }
}

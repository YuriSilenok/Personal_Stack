using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Frolov_Lib;

namespace Personal_Stack
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> St1 = new MyStack<int>();

           
            int n;

            do
            {
                Console.WriteLine("Введите размерность стека");
            }
            while (!int.TryParse(Console.ReadLine(), out n));
            Console.WriteLine();

            InputR(St1,n);

            Console.WriteLine(St1.ToString());

            MyStack<int> St2 = DellEverySecond(St1);

            Console.WriteLine(St1.ToString());
            Console.WriteLine(St2.ToString());

            Console.ReadLine();


        }
        /// <summary>
        /// Метод добавляет в Стек случайные числа
        /// </summary>
        /// <param name="st">В этот Стек будут добавлены случайные числа</param>
        /// <param name="n">Столько случайных чисел будет добавлено в Стек</param>
        public static void InputR(MyStack<int> st, int n)
        {
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                st.Push( rnd.Next(0, 100));
            }
        }



        public static MyStack<int> DellEverySecond(MyStack<int> myStack)
        {
            MyStack<int> rever = new MyStack<int>();
            MyStack<int> result = new MyStack<int>();


            while(myStack.Count() > 0)
            {
                rever.Push(myStack.Pop());
            }

            for (bool push = true; rever.Count() > 0; push = !push)
            {
                int tmp = rever.Pop();

                myStack.Push(tmp);

                if (push)
                {
                    result.Push(tmp);
                }
   
            }
            return result;
        }
    }
}

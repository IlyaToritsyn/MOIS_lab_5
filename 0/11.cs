using System;
using System.Linq;
using MyDeque;

namespace _11
{
    //11. Дек заполнен случайным образом целыми числами.
    //Найти в деке макс. и мин. элементы и поменять их местами.
    class Program
    {
        /// <summary>
        /// Заполнение дека случайными целыми числами.
        /// </summary>
        /// <param name="queue">Заполняемый дек</param>
        public static void FillRandom(MyDeque<int> deque)
        {
            Random random = new Random();

            for (int i = 0; i < 15; i++)
            {
                deque.PushTail(random.Next(-15, 16));
            }
        }

        /// <summary>
        /// Вывод элементов дека в консоль.
        /// </summary>
        /// <param name="queue">Выводимый дек</param>
        public static void OutputConsole(MyDeque<int> deque)
        {
            foreach (int element in deque)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Перемена местами чисел a и b в деке.
        /// </summary>
        /// <param name="deque">Изменяемый дек.</param>
        /// <param name="a">Число 1</param>
        /// <param name="b">Число 2</param>
        public static void Swap(MyDeque<int> deque, int a, int b)
        {
            for (int i = 0; i < deque.Count; i++)
            {
                int current = deque.Pop();

                if (current == a)
                {
                    deque.PushTail(b);
                }

                else if (current == b)
                {
                    deque.PushTail(a);
                }

                else
                {
                    deque.PushTail(current);
                }
            }
        }

        public static void Main()
        {
            MyDeque<int> deque = new MyDeque<int>();

            FillRandom(deque);

            Console.WriteLine("Исходный дек целых чисел:");

            OutputConsole(deque);
            Swap(deque, deque.Max(), deque.Min());

            Console.WriteLine("Дек с поменянными местами макс. и мин. элементами:");

            OutputConsole(deque);
        }
    }
}

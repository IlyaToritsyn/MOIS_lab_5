using MyDeque;
using System;

namespace _15
{
    //15. Найти в данном деке, заполненном случайным образом, отрицательные элементы, удалить эти элементы и вставить вместо них модули удаленных.
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
        /// Приведение всех значений дека к абсолютному виду.
        /// </summary>
        /// <param name="deque">Изменяемый дек</param>
        public static void ToAbs(MyDeque<int> deque)
        {
            for (int i = 0; i < deque.Count; i++)
            {
                int current = deque.Pop();

                deque.PushTail(Math.Abs(current));
            }
        }

        static void Main()
        {
            MyDeque<int> deque = new MyDeque<int>();

            FillRandom(deque);

            Console.WriteLine("Исходный дек целых чисел:");

            OutputConsole(deque);

            ToAbs(deque);

            Console.WriteLine("Дек с абсолютными значениями:");

            OutputConsole(deque);
        }
    }
}

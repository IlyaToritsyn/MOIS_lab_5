using System.Collections.Generic;
using System.Collections;

namespace MyDeque
{
    /// <summary>
    /// Обобщённый класс для работы с деком.
    /// </summary>
    /// <typeparam name="T">Тип данных</typeparam>
    public class MyDeque<T> : IEnumerable<T>
    {
        /// <summary>
        /// Класс элементов дека.
        /// </summary>
        private class Element
        {
            public Element Next { get; set; }
            public T Val { get; set; }

            public Element()
            {

            }

            public Element(T a)
            {
                Val = a;
                Next = null;
            }
        }

        Element Head = null;

        public MyDeque()
        {

        }

        /// <summary>
        /// Добавление элемента в начало дека.
        /// </summary>
        /// <param name="a">Добавляемый элемент</param>
        public void Push(T a)
        {
            Element tmp = new Element(a)
            {
                Next = Head
            };
            Head = tmp;
        }

        /// <summary>
        /// Добавление элемента в конец дека.
        /// </summary>
        /// <param name="a">Добавляемый элемент</param>
        public void PushTail(T a)
        {
            Element tmp = new Element(a);

            if (Head != null)
            {
                Element t = Head;

                while (t.Next != null)
                {
                    t = t.Next;
                }

                t.Next = tmp;
            }

            else
            {
                Head = tmp;
            }
        }

        /// <summary>
        /// Подсчёт количества элементов в деке.
        /// </summary>
        public int Count
        {
            get
            {
                int count;
                Element t = Head;

                for (count = 0; t != null; count++)
                {
                    t = t.Next;
                }

                return count;
            }
        }

        /// <summary>
        /// Снятие элемента с начала дека.
        /// </summary>
        /// <returns>Снятый с начала дека элемент</returns>
        public T Pop()
        {
            if (Head != null)
            {
                T a = Head.Val;
                Head = Head.Next;

                return a;
            }

            else
            {
                return default;
            }
        }

        /// <summary>
        /// Снятие элемента с конца дека.
        /// </summary>
        /// <returns>Снятый с конца дека элемент</returns>
        public T PopTail()
        {
            if (Head != null)
            {
                Element t = Head;

                while (t.Next.Next != null)
                {
                    t = t.Next;
                }

                T last = t.Next.Val;
                t.Next = null;

                return last;
            }

            else
            {
                return default;
            }
        }

        /// <summary>
        /// Возвращение строкового представления экземпляра класса.
        /// </summary>
        /// <returns>Строковое представление экземпляра класса.</returns>
        public override string ToString()
        {
            string str = "";

            if (Head != null)
            {
                Element t = Head;

                while (t != null)
                {
                    str += t.Val + " ";
                    t = t.Next;
                }
            }

            return str;
        }

        /// <summary>
        /// Перебор элементов дека.
        /// </summary>
        /// <returns>Элементы дека.</returns>
        public IEnumerator<T> GetEnumerator()
        {
            var tmp = Head;

            while (tmp != null)
            {
                yield return tmp.Val;

                tmp = tmp.Next;
            }
        }

        /// <summary>
        /// Поддержка интерфейса IEnumerable.
        /// </summary>
        /// <returns>Результат перебора элементов дека.</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

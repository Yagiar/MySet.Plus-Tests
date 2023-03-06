using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MySet<T>
    {
        List<T> list;

        public MySet(List<T> list)
        {
            this.list = list;
        }
        public MySet()
        {
            list = new List<T>();
        }



        public void Add(T element)
        {
            if (list.Contains(element))
            {
                throw new Exception("The element is already in the set.");
            }
            else list.Add(element);
        }

        public void Remove(T element)
        {
            if (!list.Contains(element))
            {
                throw new Exception("The element is already in the set.");
            }
            else list.Remove(element);
        }

        public MySet<T> Objedinenie(MySet<T> Set)
        {
            List<T> answerList = new List<T>();
            List<T> elements = Set.list;
            for (int index = 0; index < list.Count; index++)
            {
                if (!answerList.Contains(list[index]))
                {
                    answerList.Add(list[index]);
                }
            }
            for (int index = 0; index < elements.Count; index++)
            {
                if (!answerList.Contains(elements[index]))
                {
                    answerList.Add(elements[index]);
                }
            }
            return new MySet<T>(answerList);
        }

        public MySet<T> Peresechenie(MySet<T> Set)
        {
            List<T> answerList = new List<T>();
            List<T> elements = Set.list;
            for (int firstIndexList = 0; firstIndexList < list.Count; firstIndexList++)
            {
                if (elements.Contains(list[firstIndexList]))
                {
                    answerList.Add(list[firstIndexList]);
                }
            }
            return new MySet<T>(answerList);
        }

        public MySet<T> Raznost(MySet<T> Set) //Данное без входящего
        {
            List<T> answerList = new List<T>();
            List<T> elements = Set.list;
            for (int i = 0; i < list.Count; i++)
            {
                if (!elements.Contains(list[i]))
                {
                    answerList.Add(list[i]);
                }
            }
            return new MySet<T>(answerList);
        }

        public MySet<T> SimRaznost(MySet<T> Set)
        {
            List<T> answerList = new List<T>();
            List<T> elements = Set.list;
            for (int i = 0; i < list.Count; i++)
            {
                if (!elements.Contains(list[i]))
                {
                    answerList.Add(list[i]);
                }
            }
            for (int i = 0; i < elements.Count; i++)
            {
                if (!list.Contains(elements[i]))
                {
                    answerList.Add(elements[i]);
                }
            }
            return new MySet<T>(answerList);
        }

        public bool InSet(T element)
        {
            return list.Contains(element);
        }

        public bool InSet(MySet<T> Set) //Данное множество содержит входящее?
        {
            List<T> elements = Set.list;
            for (int i = 0; i < elements.Count; i++)
            {
                if (!list.Contains(elements[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public String ToString()
        {
            string answ = "";
            list.Sort();
            for (int i = 0; i < list.Count - 1; i++)
            {
                answ += list[i] + ",";
            }
            answ += list[list.Count - 1];
            return answ;
        }

    }
}

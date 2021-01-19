using System;
using System.Collections.Generic;

namespace ConsoleApp11
{
    public class Question18<T> where T:struct
    {
        private List<T> storage = new List<T>();

        public void Add(T item)
        {
            storage.Add(item);
        }

        public T Get(int index)
        {
            return storage[index];
        }

        /*public List<T> Sorted()
        {
        
        }*/
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            Question18<int> q18 = new Question18<int>();
            q18.Add(10);
            q18.Add(20);
            Console.WriteLine(q18.Get(0));


        }
    }
}

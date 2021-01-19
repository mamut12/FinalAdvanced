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


    // Question21

    public class Exam
    {
        public event Question21EventHendeler Question21Event;

    }

    public delegate void Question21EventHendeler(object source, Question21Event e);
    public class Question21Event : EventArgs
    {
        public Student student { get; set; }

        public Question21Event(Student student)
        {
            this.student = student;
        }

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

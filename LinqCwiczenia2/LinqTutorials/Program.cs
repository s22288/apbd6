using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTutorials
{
    class Program
    {
        
        

        
        static void Main(string[] args)
        {
            IEnumerable<Models.Emp> enumerable = LinqTasks.Task1();
            for (int i = 0; i < enumerable.Count(); i++)
            {
                Console.WriteLine(enumerable.ElementAt(i));
            }
            IEnumerable<Models.Emp> enumerable1 = LinqTasks.Task2();
            for (int i = 0; i < enumerable1.Count(); i++)
            {
                Console.WriteLine(enumerable1.ElementAt(i));
            }
            int v = LinqTasks.Task3();
            Console.WriteLine(v);
            IEnumerable<Models.Emp> enumerable2 = LinqTasks.Task4();
            for (int i = 0; i < enumerable2.Count(); i++)
            {
                Console.WriteLine(enumerable2.ElementAt(i));
            }


            IEnumerable<object> enumerable3 = LinqTasks.Task5();

            for (int i = 0; i < enumerable3.Count(); i++)
            {
                Console.WriteLine(enumerable3.ElementAt(i));
            }
            IEnumerable<object> enumerable4 = LinqTasks.Task6();

            for (int i = 0; i < enumerable4.Count(); i++)
            {
                Console.WriteLine(enumerable4.ElementAt(i));
            }

            IEnumerable<object> enumerable5 = LinqTasks.Task7();
            for (int i = 0; i < enumerable5.Count(); i++)
            {
                Console.WriteLine(enumerable5.ElementAt(i));
            }
            bool v1 = LinqTasks.Task8();

            Console.WriteLine(v1);
            Models.Emp emp = LinqTasks.Task9();

            Console.WriteLine(emp);
            IEnumerable<object> enumerable6 = LinqTasks.Task10();

            for (int i = 0; i < enumerable6.Count(); i++)
            {
                Console.WriteLine(enumerable6.ElementAt(i));
            }

            IEnumerable<object> enumerable7 = LinqTasks.Task11();

            for (int i = 0; i < enumerable7.Count(); i++)
            {
                Console.WriteLine(enumerable7.ElementAt(i));
            }
            IEnumerable<Models.Emp> enumerable8 = LinqTasks.Task12();

            for (int i = 0; i < enumerable8.Count(); i++)
            {
                Console.WriteLine(enumerable8.ElementAt(i));
            }
            IEnumerable<Models.Dept> enumerable9 = LinqTasks.Task14();
            for (int i = 0; i < enumerable9.Count(); i++)
            {
                Console.WriteLine(enumerable9.ElementAt(i));
            }

        }
        
    }
}

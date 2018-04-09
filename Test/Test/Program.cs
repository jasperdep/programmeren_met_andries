using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int i = 123;
            object o = (object)i;

            Console.WriteLine(o);

            int age = 11;
            Person piet = new Person();

            int myAge = age;

            Person sjaak = piet;
            piet = null;

            Console.WriteLine(sjaak.height);
            Console.ReadLine();
            
        }

    }
    class Person
    {
        public int height = 2000;
    }
}

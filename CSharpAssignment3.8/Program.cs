using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] MyArray = { "zebra", "Ant", "Owl", "Lion" };
            for(int i = 0; i < MyArray.Length; i++)
            {
                Console.WriteLine(MyArray[i]);
            }

            foreach(var n in MyArray)
            {
                Console.WriteLine(n);
            }

            int a = 0;
            while (a < MyArray.Length)
            {
                Console.WriteLine(MyArray[a]);
                a++;
            }

            int x = 0;
            do
            {
                Console.WriteLine(MyArray[x]);
                x++;
            }
            while (x < MyArray.Length);


            //Sorting
            Console.WriteLine("---------------");

            string[] c = MyArray;

            Array.Sort(c);
            foreach(var value in c)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("---------------");

            string[] animals = { "Zebra", "Kiwi", "Amazona Parrot", "Tiger" };
            string[] places = { "Africa", "New Zealand", "Jamaica", "India" };
            Array.Sort(animals);
            Array.Sort(places);

            foreach (var b in animals)
            {
                Console.WriteLine(b);
            }

            Console.WriteLine("=====================");
            foreach (var z in places)
            {
                Console.WriteLine(z);
            }


            Console.Read();

        }
    }
}

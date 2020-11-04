using System;

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            // MyClass indexer
            MyClass myClass = new MyClass();
            myClass[0] = 1;
            myClass[1] = 2;
            myClass[2] = 3;
            Console.WriteLine(myClass[0]);
            Console.WriteLine(myClass[1]);
            Console.WriteLine(myClass[2]);

            //MyClass1 indexer
            MyClass1 myClass1 = new MyClass1();
            myClass1[0] = "string1";
            myClass1[1] = "string2";
            myClass1[2] = "string3";
            Console.WriteLine(myClass1[0]);
            Console.WriteLine(myClass1[1]);
            Console.WriteLine(myClass1[2]);
            Console.WriteLine();

            //Dictionary index
            Dictionary dictionary = new Dictionary();
            Console.WriteLine(dictionary["Girq"]);
            Console.WriteLine(dictionary["Jur"]);
            Console.WriteLine(dictionary["Katu"]);
            Console.WriteLine();

            //Virtual indexer
            DerivedClass derivedClass = new DerivedClass();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(derivedClass[i]);
            }
            Console.WriteLine();
        }
    }
}

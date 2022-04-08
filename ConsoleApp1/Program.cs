﻿using System;

namespace ConsoleApp1
{
    public delegate string HelloDelegate(string name);

    class SomeClass
    { 

        public string SayHello(string s)
        {
            return $"Привет, {s}";
        }

    }

    class Program
    { 
        static void Main(string[] args)
        {
            SomeClass someClass = new SomeClass();
            HelloDelegate hD = new HelloDelegate(someClass.SayHello);
            Console.WriteLine(hD.Invoke("Вася"));
            Console.ReadKey();
        }
    }
}

using System;

namespace ConsoleApp3
{
{
public delegate void MyDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate mD = new MyDelegate(delegate { Console.WriteLine("Hello World!"); });



            mD(); //mD.Invoke



            Console.ReadKey();
        }
    }

}

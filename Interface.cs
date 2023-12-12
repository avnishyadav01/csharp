using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Dark
{
    internal class Program
    {
        interface Il
        {
            void test();//In interface we don't specify the access modifier by default they are public and method is abstract
        }
        interface Ik
        {
            void test(); 
        }
        class Abc : Il, Ik //In class we can inherit many interface as we want and also can inherit one class but it must be
                           //at the start
        {
            public void test()  //We specify only one method and it will work fine both interface thinks that this method is their
            {
                Console.WriteLine("Hello interface");
            }

            static void Main()
            {
                Abc abc = new Abc();
                abc.test();
                Console.ReadLine();
            }
        }
    }
}

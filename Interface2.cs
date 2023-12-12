using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dark
{
    interface h2
    {
        void run(int x);
    }
    interface h3
    {
        void run(int x);
    }
    internal class Interface2:h2,h3
    {
        void h2.run(int x)     // We create the method for each interface it is a good approach to specify this method belongs
                           // this interface as there can be same methods in the interface
        {
            Console.WriteLine(2*x);
        }
        void h3.run(int x) 
        { 
            Console.WriteLine(x*3); 
        }
        public static void Main()
        {
            h2 ter = new Interface2();    // We create the object of h2 instance but it refers the class reference 
            h3 ter1 = new Interface2();
            ter.run(5);
            ter1.run(5);
            Console.ReadLine();
        }
    }
}

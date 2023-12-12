using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokerr
{
    class A
    {
        public int x;
        public int y=6;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> l = new List<int>() {1,4,5}; //Generic list in which specify our data type and it will take
            l.Add(11); //input only in their specific data type .Generic list is safe
            l.Add(12);  //Add data in generic list
            System.Console.WriteLine(l.Capacity);
            Console.WriteLine(l[1]);
            List<A> b=new List<A>(); // Generic list of class data type 
            b.Add(new A());  //Adding data in our class list data type
            b[0].x = 5;
            Console.WriteLine(b[0].x + b[0].y);
            foreach(var u in b)
            {
                Console.WriteLine(u.x);
            }
            Console.ReadLine();

        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Jokerr
{
    class A
    {
        public int x;
        public int y;
    }
    class B
    {
        public int q;
        public int r;
    }
  
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,A> map = new Dictionary<int,A>();// Dictionary entry has key of int type and value of class A type
            A a = new A(); 
            a.x = 4; a.y = 5;
            map.Add(4, a); //Adding key value in dictionary
            B b = new B();
            b.q = 2;
            b.r = 4;
       
            Console.WriteLine(map[4].y);
            map[0] = a; //by this we are adding key 0 ind dictionary and its value is object of class A
            foreach (var x in map)
            {
                Console.WriteLine(x.Key+" "+x.Value.x); //output the value in map dictionary 
            }



            Console.ReadLine();

        }
    }
}

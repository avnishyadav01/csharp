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
            Dictionary<int,A> map = new Dictionary<int,A>();
            A a = new A();
            a.x = 4; a.y = 5;
            map.Add(4, a);
            Console.WriteLine(map[4].y);

           
            Console.ReadLine();

        }
    }
}

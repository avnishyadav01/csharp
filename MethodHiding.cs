using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zero
{
    class random
    {
      public void ra()
        {
            Console.WriteLine("Base class");
        }
    }
    class rupay :random
    {
        public new void ra() //Method hiding new keyword is optional program will also work without new 
        {
            
            Console.WriteLine("child class");
            base.ra(); // base.ra() calls the base class method
        }
        static void Main()
        {
            rupay no = new rupay();
            no.ra();
            Console.ReadLine();
        }
        
    }
}

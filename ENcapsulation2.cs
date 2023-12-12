using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dark
{
    internal class Red
    {
        int CustomerId;      // Encapsulation means that our field should always be private and there functions should bind
                           // them .Binding the data members and methods means the encapsulation
        string CustomerName;
        public void set()   // Method for entering the data 
            {
            CustomerId=int.Parse(Console.ReadLine());
            CustomerName=Console.ReadLine();
            }
        public void get()  // Method for showing the data 
        {
            Console.WriteLine(CustomerId); Console.WriteLine(CustomerName);
        }
        
    }
    class gh
    {
        static void Main() 
        {
            Red g = new Red();
            g.set();
            g.get();
            Console.ReadLine();
        }
    }
}

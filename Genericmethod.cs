using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//Gneric Method
namespace Jokerr
{
    class A
    {
        public int x;
        public int y;
       public static void func<T>(T ab , T ac) // In generic method we doesn't define the data type of our paramteres instead we use a temporary keyword and we define our
            // data type of our parameter when we call the function
        {
            if (ab.Equals(ac)) // Equals method for checki whether they are equal or not we cannot use == operator 
            {
                Console.WriteLine("Equal");
            }
            else
                Console.WriteLine("Not Equal");
 
        }
        public static void ab<P,Q,R>(P r ,Q s , R aas) // We can take many temporary data types
        {
            Console.WriteLine(r+" " +aas);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            A.func<int>(2, 4);      // Calling the generic method and we also define the data type
            A.func<string>("rav","rav"); // It's the same function but in this we change the data type
            A.ab<int, string, float>(4,"av",4.5f); // Generic method take the multiple temporary data type 
            



            Console.ReadLine();

        }
    }
}

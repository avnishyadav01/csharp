using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Jokerr
{

    internal class Program
    {
        static void rer()
        {
            try
            {
                rer2();
            }
            catch(Exception e)
            {
                throw e; //throw e is used when we hace to stop the stack trace by using throw e it will not show the path of the stack trace and other cannot find the directory
                // or our structure of program
            }
        }
        static void rer2() 
        {
            try
            {
                rab();
            }
            catch(Exception e)
            {
                throw ; // throw keyword is used to throw the exception to the parent catch by using throw keyword we make the chain of the exception it is used when the
                        // there is a method in throw catch 
            }

        }
       static void rab()
        {
            try
            {
                int x = 1, y = 0;
                int z = x / y;
            }
            catch(Exception e)
            {
                throw new Exception("Rabaaa") ;//throw new exception is used when we want to thwor our message to the above catch
            }
        } 
   
        static void Main(string[] args)
        {
            try
            {
                rer();
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace); // stack trace is used to print the trace of our exception
            }

            Console.ReadLine();

        }
    }
}

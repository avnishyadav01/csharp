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
        static void Main(string[] args)
        {
            try  // try  is the block of code will get executed and if there is any exception then catch block will executed  
            {
                try // We can have nested try and catch 
                {
                    int[] a = new int[3];
                    a[4] = 5;
                }
                catch (ArithmeticException e) // In the above case there is exception in catch then compiler will go to catch block
                // Arithmetic Exception will catch only arithmetic exceptions if there is not arithmex exception catch will not be executed
                {
                    Console.WriteLine("error");
                    Console.WriteLine(e.Message);
                }
            }

        catch (Exception e) // In the above case our exception is out of bound but above catch will only catch the arithmeticexception if catch cannot catch the exception then 
            {// if there is a other parent catch then it will try to catch the exception
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("try and catch executed finally will always executed");
            }
            Console.ReadLine();

        }
    }
}

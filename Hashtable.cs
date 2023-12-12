using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joker
{
    internal class Program
    {

        static void Main()
        {
            Hashtable h = new Hashtable() { { 1, true }, { "ran", 5 }, { 3.44, 'c' } }; //Initializing Hash table
            h[0] = 1.4; //We can add value by and the index will be the key
            h.Add(11, 6);//Add function
            Console.WriteLine(h.Count);
            h.Remove(0);//Remove by giving the key both key and the value will be remove
            foreach(DictionaryEntry e in h) //DictionaryEntry gives the key value pair
            {
                Console.WriteLine(e.Key+" "+e.Value); //We can output the hashtable like this 
            }
            Console.ReadLine();
            

        }
    }
}

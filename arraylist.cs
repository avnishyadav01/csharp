using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Joker
{
    class Program
    {
        public static void Main()
        {
            ArrayList ab = new ArrayList();
            ArrayList cd = new ArrayList(3);
            Console.WriteLine("Size of cd arracylist cd is " + cd.Capacity); //size will be 3 because we define cd size 3
            cd.Add(12); // to add variable in array list data type is object so we can add any type of data
            cd.Add("2f");
            cd.Add(122);
            cd.Add(false);
            Console.WriteLine("Size of cd arracylist cd is " + cd.Capacity);// we add only 4 variable but size becomes 6
            // if we define size 3 ,next size will increase to 6 and then 12 and then 24
            Console.WriteLine("Size of ab arracylist ab is "+ ab.Capacity);// we donot define the size of ab list so size
            //will be zero
            ab.Add("rabada");
            Console.WriteLine("Size of ab arracylist ab is " + ab.Capacity); // We only add 1 variable and size increase to 
            // 4 if we don't define the size it will become 4 and then 8 after that 16
            ab.Add(2);
            ab.Add(true);
            ab.Add(false);
            ab.Add(21);
            foreach (var i in ab)
                Console.WriteLine(i);
            Console.WriteLine("Size of ab arracylist ab is " + ab.Capacity); // size increase to 8
            ab.Remove(2); // it will remove the data which has 2 value
            ab.RemoveAt(0); // it will remove the 0th index
            foreach (var i in ab)
                Console.WriteLine(i);

            Console.ReadLine();

        }
    }
}

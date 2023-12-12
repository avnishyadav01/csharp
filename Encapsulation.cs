using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joker
{
    class Propertiesgetset
    {
        string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        public string decx //get set properties
            {get;set;
              }
    }
    class Propertiesgetset1:Propertiesgetset
    {
        static void Main()
        {
            Propertiesgetset1 a = new Propertiesgetset1();
            a.Name = "asa";
            Console.WriteLine(a.Name);
            Console.ReadLine();
            a.decx = "asaaa";
            Console.WriteLine(a.decx);
            Console.ReadLine();
        }
        
    }


}

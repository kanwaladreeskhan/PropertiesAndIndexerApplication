using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesAndIndexerApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Property obj1 = new Property();//using property
            obj1.eName = "Scooby";
            obj1.eDept = "Design";
            Console.WriteLine("Name : {0} \nDepartment : {1}", obj1.eName, obj1.eDept);
            Indexer obj2 = new Indexer();
            obj2.list[1] = 3;
            obj2.list[2] = 4;
            Console.WriteLine("list[1] : {0} \nlist[2] : {1}", obj2.list[1], obj2.list[2]);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesAndIndexerApplication
{
    internal class Indexer
    {
        public int[] list = new int[10];
        public int this[int index]
        {
            set
            {
                list[index] = value;
            }
            get
            {
                return list[index];
            }
        }
    }
}

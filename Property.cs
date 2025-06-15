
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesAndIndexerApplication
{
    internal class Property
    {
        public string eName;
        private string internalDept;
        public string eDept
        {
            get
            {
                return internalDept;
            }
            set
            {
                internalDept = value;
            }
        }
    }
}

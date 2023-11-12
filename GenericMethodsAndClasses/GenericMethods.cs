using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethodsAndClasses
{
    public class GenericMethods
    {
        //Generic methods are used as templates to reuse code for different value types instead of needing to rewrite the code for a new value type
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethodsAndClasses
{
    internal class Elems <T>
    {
       
        //make this class generic
        
        
            public T[] elements = new T[3];

            public void Add(T elem1, T elem2, T elem3)
            {
                elements[0] = elem1;
                elements[1] = elem2;
                elements[2] = elem3;
            }

            public void Show()
            {
                foreach (T item in elements)
                {
                    Console.Write(item + " ");
                }
            }
        }
    }



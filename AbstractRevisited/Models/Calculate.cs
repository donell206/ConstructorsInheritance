using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractRevisited.Models
{
    public abstract class Calculate
    {

        public int Add(int a, int b)
        {
            return a+b;
        }
         
         public abstract int Sub(int a, int b)
        



    }
}

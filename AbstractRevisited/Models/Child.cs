using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractRevisited.Models
{
    public class Child : Calculate
    {
        public override int Sub(int a, int b)
        {
            return a - b;
        }
    }
}

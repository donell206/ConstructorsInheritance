﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceFirstDemo.Models
{
    public interface ICalculate
    {
        int Add(int a, int b);
        int Sub(int a, int b);
        int Mult(int a, int b);
        int Div(int a, int b);

    }
}

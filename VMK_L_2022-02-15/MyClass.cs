using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMK_L_2022_02_15;

public class MyClass
{
    private int x;
    private string str;

    public MyClass()
    {
        //x = 0;
        str = "";
    }

    public MyClass(int a, string s)
    {
        (x, str) = (a, s);
    }

    public MyClass(string str)
    {
        this.str = str;
    }

    public override string ToString()
    {
        return $"x={x}, str={str}";
    }

    public override bool Equals(object? obj)
    {
        if (obj == null) return false;
        if (!(obj is MyClass)) return false;
        return (x == ((MyClass)obj).x && str.Equals(((MyClass)obj).str));
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMK_L_2022_02_15;

public enum Month
{
    January = 1,
    February,
    March,
    April,
    May,
    June,
    July,
    August,
    September,
    October,
    November,
    December,
}

public class MyClass
{
    public enum DayOfWeek
    {
        Понедельник = 1,
        Вторник = 2,
        Среда = 3,
        Четверг,
        Пятница,
        Суббота,
        Воскресенье = 0
    }

    public DayOfWeek Day;
    public Month Month;

    private int x;
    private string str;

    private const int minX = -3;
    private const int maxX = 3;
    public int A { get; set; }

    public int X
    {
        get => x; 
        set => x = Math.Min(maxX, Math.Max(minX, value));
    }

    public string Str => str;

    public char this[DayOfWeek i]
    {
        get
        {
            if (str != null && str != "")
            {
                if (i >= 0 && (int)i < str.Length)
                    return str[(int)i];
            }

            return '-';
        }
        set
        {
            if (str != null && str.Length >= (int)i+1)
            {
                var ca= str.ToCharArray();
                ca[(int)i] = value;
                str = ca.ToString();
            }
        }
    }
    public string Str2
    {
        get;
        init;
    }

    public MyClass()
    {
        //x = 0;
        str = "";
        Str2 = "Привет!";
        // Свойства с инициализаторами можно изменять
        // в рамках конструкторов
        Str2 = "Упс";
        Day = DayOfWeek.Пятница;
        Month = Month.February;
    }

    public MyClass(int a, string s)
    {
        (X, str) = (a, s);
        Str2 = "И снова привет!";
    }

    public MyClass(string str)
    {
        this.str = str;
    }

    public override string ToString()
    {
        var symb = (str!=null && str!="") ? str[0] : '-';
        return $"x={x}, str={str}, day={(int)Day}, symb={symb}";
    }

    public override bool Equals(object? obj)
    {
        if (obj == null) return false;
        if (!(obj is MyClass)) return false;
        return (x == ((MyClass)obj).x && str.Equals(((MyClass)obj).str));
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(x, str);
    }
}
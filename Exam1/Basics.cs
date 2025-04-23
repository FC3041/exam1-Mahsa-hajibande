using System.Data;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Exam1;

public class Q1_Add
{
    public static int Add (int a ,int b)
    {
        return a + b;
    }
}


public class Basics
{
    public int _v {get; set;}
    public int _f {get; set;}

    public static Basics Q2MultiplyAndReset (ref int i , ref int j)
    {
        Basics B = new Basics ();
        i = i * j ;
        j = 1 ;
        B._v = i ;
        B._f = j ;
        return B ;
    }
}

public interface IShape
{
    public double GetArea ();
    public double GetPerimeter ();
}

public class Q7Circle : IShape
{
    public double radius {get; set;}

    public Q7Circle (double r)
    {
        radius = r ;
    }

    public double GetArea ()
    {
        return (Math.PI * radius * radius);
    }

    public double GetPerimeter ()
    {
        return (2 * Math.PI * radius);
    }
}

public class Q7Rectangle : IShape
{
    public double height {get; set;}
    public double width {get; set;}

    public Q7Rectangle (double H , double W)
    {
        height = H ;
        width = W ;
    }

    public double GetArea ()
    {
        return height * width ;
    }

    public double GetPerimeter ()
    {
        return 2 * (height + width) ;
    }
}

public class ShapeUtils
{
    public static double Q7TotalArea (IShape [] shapes)
    {
        double total = 0 ;
        foreach (IShape item in shapes)
        {
            total += item.GetArea ();
        }
        return total ;
    }
}



public class Q4Person
{
    public string Name {get; set;}
    public int Age {get; set;}
    public Q4Person (string name , int age)
    {
        Name = name ;
        Age = age ;
    }

    public string Introduce ()
    {
        return ($"Hello, my name is {Name} and I am {Age} years old.") ;
    }

}


public class Q6Temperature
{
    public double Fahrenheit
    {
        get
        {
            return Fahrenheit ;
        }

        set
        {
            value = (Celsius * 9 / 5) + 32 ;
            value = Fahrenheit ;
        }
    }
    public double Celsius
    {
        get
        {
            return Celsius ;
        }
        set
        {
            value = (Fahrenheit - 32) * 5 / 9 ;
            value = Celsius ;
        }
    }
}

public class Type1
{
    public int Count
    {
        get
        {
            return Count ;
        }
        set
        {
            Count = Count ;
        }
    }

}

public class Type2
{
    public int Count
    {
        get
        {
            return Count ;
        }
        set
        {
            Count = Count ;
        }
    }
}

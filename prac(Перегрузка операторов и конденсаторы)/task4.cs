using System;
using System.Text;

public class Vector
{
    private double[] _components;

    public Vector(params double[] components)
    {
        _components = (double[])components.Clone();
    }

    public double this[int index]
    {
        get
        {
            if (index < 0 || index >= _components.Length)
                throw new IndexOutOfRangeException();
            return _components[index];
        }
        set
        {
            if (index < 0 || index >= _components.Length)
                throw new IndexOutOfRangeException();
            _components[index] = value;
        }
    }

    public static double operator *(Vector a, Vector b)
    {
        if (a._components.Length != b._components.Length)
            throw new ArgumentException("Размерности не совпадают.");
        double res = 0;
        for (int i = 0; i < a._components.Length; i++)
            res += a._components[i] * b._components[i];
        return res;
    }

    public override string ToString()
    {
        var sb = new StringBuilder("[");
        for (int i = 0; i < _components.Length; i++)
        {
            if (i > 0) sb.Append(", ");
            sb.Append(_components[i]);
        }
        sb.Append("]");
        return sb.ToString();
    }
}

public class Program
{
    public static void Main()
    {
        Vector v1 = new Vector(1, 2, 3);
        Vector v2 = new Vector(4, 5, 6);

        Console.WriteLine(v1 * v2); 
        v1[1] = 10;
        Console.WriteLine(v1);      
    }
}
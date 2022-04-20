using System.Runtime.Intrinsics.X86;

namespace PrZadanie;

public abstract class Figure
{
    public double Square { get; set; }
    public double Perimetr { get; set; }
}

public class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public override string ToString()
    {
        return $"X:{X} Y:{Y}";
    }
    
}

public interface N_angle
{
    Point[] Points { get; set; }
    int CountPoints();
    double Height();
    double Base();
    double AngleBaseAdjSide();
    double CountSides();
    double[] LengthSide();

}

public class Triangle : Figure,N_angle
{

    private const int countPoints = 3;
    public Point[] Points { get; set; }

    public int CountPoints()
    {
        return countPoints;
    }

    public double Height()
    {
        return 100;
    }

    public double Base()
    {
        return 200;
    }

    public double AngleBaseAdjSide()
    {
        return 90;
    }

    public double CountSides()
    {
        return countPoints;
    }

    public double[] LengthSide()
    {
        return new double[countPoints] {3, 4, 5};
    }

    public override string ToString()
    {
        return $"Треугольник";
    }
}


public class FourAngle : Figure,N_angle
{

    private const int countPoints = 4;
    public Point[] Points { get; set; }

    public int CountPoints()
    {
        return countPoints;
    }

    public double Height()
    {
        return 100;
    }

    public double Base()
    {
        return 200;
    }

    public double AngleBaseAdjSide()
    {
        return 90;
    }

    public double CountSides()
    {
        return countPoints;
    }

    public double[] LengthSide()
    {
        return new double[countPoints] {3, 4, 5, 6};
    }

    public override string ToString()
    {
        return $"Четырехугольник";
    }
    
    //public static implicit operator FourAngle (Square S)
    //{
    //    return new Square() ;
    //}
    
}

public class Square : FourAngle
{
    public bool isSquare()
    {
        if (Points[0].X == 0) return true;
        return false;
    }

    //public static implicit operator Square (FourAngle S)
    //{
    //    return new Square() ;
    //}

    
    public override string ToString()
    {
        return "Квадрат";
    }
    
}

public class Rhomb : FourAngle
{
    public bool isRhomb()
    {
        if (Points[0].X == 0) return true;
        return false;
    }

    public override string ToString()
    {
        return "Ромб";
    }
}

public class Rectangle : FourAngle
{
    public bool isRectangle()
    {
        if (Points[0].X == 0) return true;
        return false;
    }

    public override string ToString()
    {
        return "Прямоугольник";
    }
}
public class Parallelogram : FourAngle
{
    public bool isParallelogram()
    {
        if (Points[0].X == 0) return true;
        return false;
    }

    public override string ToString()
    {
        return "Параллелограм";
    }
}
using RetodDeProgramacion.Model;

namespace RetodDeProgramacion.Challenges;

public interface Polygon
{
    double Area();
    void ShowArea(); 
}


public class PolygonArea : Challenge
{
    public override void DoTheAction(ChallengeCompleted challenge)
    {
        Console.WriteLine($"{challenge.Number} challenge: {challenge.Name}");
        CalculatePolygonArea();
    }

    public void CalculatePolygonArea()
    {
        Console.WriteLine();
        Console.WriteLine("Please choose what polygon do you want to calculate:");
        Console.WriteLine("1) Triangle");
        Console.WriteLine("2) Square");
        Console.WriteLine("3) Rectangle");
        var answer = Console.ReadLine();
        switch (answer)
        {
            case "1":
                string baseS;
                double baseN;
                string heightS;
                double heightN;
                do
                {
                    Console.Write("Please write here your Base:");
                    baseS = Console.ReadLine();
                } while (!double.TryParse(baseS, out baseN));
                do
                {
                    Console.Write("Please write here your Height:");
                    heightS = Console.ReadLine();
                } while (!double.TryParse(heightS, out heightN));
                Triangle triangle = new (baseN, heightN);
                triangle.ShowArea();
                break;
            
            case "2":
                string sizeS;
                double sizeN;
                do
                {
                    Console.Write("Please write here your size:");
                    sizeS = Console.ReadLine();
                } while (!double.TryParse(sizeS, out sizeN));
                Square square = new (sizeN);
                square.ShowArea();
                break;
            
            case "3":
                string widthS;
                double widthN;
                string lengthS;
                double lengthN;
                do
                {
                    Console.Write("Please write here your width:");
                    widthS = Console.ReadLine();
                } while (!double.TryParse(widthS, out widthN));
                do
                {
                    Console.Write("Please write here your Height:");
                    lengthS = Console.ReadLine();
                } while (!double.TryParse(lengthS, out lengthN));
                Rectangle rectangle = new (widthN, lengthN);
                rectangle.ShowArea();
                break;
            default:
                return;
        }
    }
}

public class Triangle : Polygon
{
    public double Base { get;}
    public double Height { get;}
    public Triangle(double @base, double height)
    {
        Base = @base;
        Height = height;
    }
    public double Area() => (Base * Height) / 2;
    public void ShowArea() => Console.WriteLine($"The triangle area is: {Area()}");
}

public class Square : Polygon
{
    public double Size { get; }
    public Square(double size)
    {
        Size = size;
    }
    public double Area() => Size * Size;
    public void ShowArea() => Console.WriteLine($"The sqare area is  {Area()}");
}
public class Rectangle : Polygon
{
    public double Width { get; set; }
    public double Length { get; set; }

    public Rectangle(double width, double length)
    {
        Width = width;
        Length = length;
    }
    public double Area() => Length * Width;
    public void ShowArea() => Console.WriteLine($"The area of the rectangle is {Area()}");
}
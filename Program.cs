using System;
// 1. check type --->

/*
class Program{
  static void Typecheck(object value){
    if (value is int){
      Console.WriteLine("Integer");
      }
    else if (value is double){
      Console.WriteLine("Double");
      }
    else if (value is string){
      Console.WriteLine("String");
      }
    else{
      Console.WriteLine("Unknown Type!!");
      }
  }
  static void Main(string[] args){
    System.Console.WriteLine("Enter the value: ");
    string? value = Console.ReadLine();
    if(int.TryParse(value, out int intValue)){
      Typecheck(intValue);
    }
    else if(double.TryParse(value, out double doubleValue)){
      Typecheck(doubleValue);
    }
    else if (string.IsNullOrEmpty(value))
    {
      Typecheck(null);
    }
    else{
      Typecheck(value);
    }
  }
}
*/

// 2. Even or Odd using Pattern Matching ---->
/*
class Program{
  static void EvenOddCheck(object value){
    if(value is int num){
      System.Console.WriteLine(num % 2 == 0? "Even" : "Odd");
    }
    else{
      System.Console.WriteLine("Not an Integer");
    }
  }
  static void Main(string[] args){
    System.Console.WriteLine("Enter the value: ");
    string? value = Console.ReadLine();
    if(int.TryParse(value, out int intValue)){
      EvenOddCheck(intValue);
    }
    else if(string.IsNullOrEmpty(value)){
      System.Console.WriteLine("No value entered");
    }
    else{
      EvenOddCheck(value);
    }
  }
}
*/

// 3. Shape Area Calculation using Switch Expression ----->

abstract class Shape{}
class Circle : Shape{
  public double Radius {get;}
  public Circle(double radius) => Radius = radius;
}
class Rectangle : Shape{
  public double Width {get;}
  public double Height {get;}
  public Rectangle(double width, double height) => (Width, Height) = (width, height);
}
class Triangle : Shape{
  public double Base {get;}
  public double Height {get;}
  public Triangle(double @base, double height) => (Base, Height) = (@base, height);
}
class Program{
  static double CalculateArea(Shape shape){
    return shape switch{
      Circle c => Math.PI * c.Radius * c.Radius,
      Rectangle r => r.Width * r.Height,
      Triangle t => 0.5 * t.Base * t.Height,
      _ => throw new ArgumentException("Unknown Shape")
    };
  }
  static void Main(string[] args){
    Shape circle = new Circle(2);
    Shape rectangle = new Rectangle(4,6);
    Shape triangle = new Triangle(3, 8);

    Console.WriteLine($"Circle Area: {CalculateArea(circle)}");
    Console.WriteLine($"Rectangle Area: {CalculateArea(rectangle)}");
    Console.WriteLine($"Triangle Area: {CalculateArea(triangle)}");
  }
}
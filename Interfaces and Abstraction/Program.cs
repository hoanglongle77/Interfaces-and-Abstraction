// See https://aka.ms/new-console-template for more information
using Interfaces_and_Abstraction.Problem_1;
using Interfaces_and_Abstraction.Problem_2;

TestProblem2();

static void TestProblem1()
{
    Console.Write("Enter circle's radius: ");
    var radius = int.Parse(Console.ReadLine());
    IDrawable circle = new Circle(radius);

    Console.Write("Enter rectangle's width: ");
    var width = int.Parse(Console.ReadLine());  
    Console.Write("Enter rectangle's height: ");
    var height = int.Parse(Console.ReadLine()); 
    IDrawable rect = new Rectangle(width, height);

    circle.Draw();
    rect.Draw();

    Console.ReadKey();
}

static void TestProblem2()
{
    ICar seat = new Seat("Leon", "Grey");
    ICar tesla = new Tesla("Model 3", "Red", 2);

    Console.WriteLine(seat);
    Console.WriteLine(tesla);
}

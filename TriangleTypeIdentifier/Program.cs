Console.Write("Enter the first side: ");
double side1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the second side: ");
double side2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the third side: ");
double side3 = Convert.ToDouble(Console.ReadLine());

if (side1 == side2 && side2 == side3)
{
    Console.WriteLine("The triangle is Equilateral.");
}
else if (side1 == side2 || side1 == side3 || side2 == side3)
{
    Console.WriteLine("The triangle is Isosceles.");
}
else
{
    Console.WriteLine("The triangle is Scalene.");
}
Console.Write("Enter your grade: ");
int grade = Convert.ToInt32(Console.ReadLine());

if (grade < 0 || grade > 100)
{
    Console.WriteLine("Invalid grade. Please enter a grade between 0 and 100.");
}
else
{
if (grade >= 90)
{
    Console.WriteLine("Your grade is: A");
}
else if (grade >= 80)
{
    Console.WriteLine("Your grade is: B");
}
else if (grade >= 70)
{
    Console.WriteLine("Your grade is: C");
}
else if (grade >= 60)
{
    Console.WriteLine("Your grade is: D");
}
else
{
    Console.WriteLine("Your grade is: F");
}
} 
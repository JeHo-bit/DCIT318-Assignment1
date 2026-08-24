Console.Write("Enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());

double ticketPrice;

if (age >= 65)
{
    ticketPrice = 7.00;
}
else
{
    ticketPrice = 10.00;
}

Console.WriteLine($"Your ticket price is GH₵{ticketPrice:F2}");
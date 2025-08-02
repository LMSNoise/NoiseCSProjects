int inputNumber;

Console.WriteLine("Input number.");
inputNumber = Convert.ToInt32(Console.ReadLine());

if ((inputNumber % 2) == 0)
{
    Console.WriteLine("tick");
}
else
{
    Console.WriteLine("tock");
}
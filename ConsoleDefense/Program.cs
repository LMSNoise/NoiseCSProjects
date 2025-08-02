Console.Title = "Defense of Consolas";

int consolasHeight = 8;
int consolasWidth = 8;

Console.WriteLine($"The city of Consolas is under attack. Deploy a 3x3 magical barrier! Note: The city of Consolas is only {consolasHeight} by {consolasWidth}, in grid measurements.");

int deployYAxis;
int deployXAxis;

Console.Write("Target row? ");
deployXAxis = Convert.ToInt32(Console.ReadLine());

Console.Write("Target column? ");
deployYAxis = Convert.ToInt32(Console.ReadLine());

if (0 > deployYAxis || deployXAxis > consolasWidth || 0 > deployYAxis || deployYAxis > consolasHeight)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("You have chosen an incorrect value!");
}
else
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Deploying to the following locations!");
    Console.WriteLine($"({deployXAxis}, {deployYAxis - 1})");
    Console.WriteLine($"({deployXAxis - 1}, {deployYAxis})");
    Console.WriteLine($"({deployXAxis}, {deployYAxis + 1})");
    Console.WriteLine($"({deployXAxis + 1}, {deployYAxis})");
    Console.Beep();
}

Console.ForegroundColor = ConsoleColor.White;
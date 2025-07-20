//calculate a triangle's area by base and height
float baseLength;
float heightLength;

Console.WriteLine("What is the base length of the triangle?");
baseLength = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What is the height of the triangle?");
heightLength = Convert.ToInt32(Console.ReadLine());

float area = (baseLength * heightLength) / 2;
Console.WriteLine("The triangle's area is: " + area);
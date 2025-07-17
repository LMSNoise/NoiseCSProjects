//the thing namerrr

Console.WriteLine("What kind of thing are we talking about?");
String objectName;
objectName = Console.ReadLine();
Console.WriteLine(objectName);

Console.WriteLine("How would you describe it? Big? Azure? Tattered");

String objectDescriptor;
string c;
int d;
//descriptor prior to the name of the object
objectDescriptor = Console.ReadLine();
c = "of DOOM 3000!!";

//output
Console.WriteLine("The " + objectDescriptor + " " + objectName + c);

/*
 * How i'd improve this... well, comments REALLY aren't enough
 * Naturally, the idea is that you write self-documenting code, so rather than use indescriptive names like "A", "B", "C", I'd rather
 * 1. Change variable names to *be* self-documenting.
 * 2. change c and d into one variable, it's unnecessary for them to be split
 * Just like that, the code is already easier to read. There are more advanced solutions, I'm sure, but I don't know how to do string formatting in this language.
 */
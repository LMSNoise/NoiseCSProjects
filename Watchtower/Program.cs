int enemyXLocation;
int enemyYLocation;
string enemyPosition;

Console.Write("Insert X value:");
enemyXLocation = Convert.ToInt32(Console.ReadLine());

Console.Write("Insert Y value:");
enemyYLocation = Convert.ToInt32(Console.ReadLine());

if  (enemyXLocation < 0)
{
    if (enemyYLocation < 0)
    {
        enemyPosition = "southwest";
    } 
    else if (enemyYLocation == 0)
    {
        enemyPosition = "west";
    }
    else
    {
        enemyPosition = "northwest";
    }
}
else if  (enemyXLocation == 0)
{
    if (enemyYLocation < 0)
    {
        enemyPosition = "south";
    }
    else if (enemyYLocation == 0)
    {
        enemyPosition = "gates";
    }
    else
    {
        enemyPosition = "north";
    }
}
else
{
    if (enemyYLocation < 0)
    {
        enemyPosition = "southeast";
    }
    else if (enemyYLocation == 0)
    {
        enemyPosition = "east";
    }
    else
    {
        enemyPosition = "northeast";
    }
}

Console.WriteLine($"The enemy is at our {enemyPosition}!!");
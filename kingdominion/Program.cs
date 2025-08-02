using System.Reflection.Metadata.Ecma335;

int estateCount;
int duchyCount;
int provinceCount;
int score;

static int readnuminput(){
    int n = 0;
    n = Convert.ToInt32(Console.ReadLine());
    return n;

}

Console.WriteLine("Insert estate count.");
estateCount = readnuminput();
Console.WriteLine("Insert duchy count.");
duchyCount = readnuminput();
Console.WriteLine("Insert province count.");
provinceCount = readnuminput();

score = estateCount + (duchyCount * 3) + (provinceCount * 6);
Console.WriteLine("Score: " + score);

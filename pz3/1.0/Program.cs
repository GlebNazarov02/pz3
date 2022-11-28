void Chet(int x, int y)
{
    if (x == 0 ||y  == 0)
        Console.WriteLine("на оси");
    else if (x > 0 && y  > 0)
        Console.WriteLine("первая");
    else if (x > 0 && y < 0)
        Console.WriteLine("четвертая");
    else if (x < 0 && y  > 0)
        Console.WriteLine("вторая");
    else if (x < 0 && y  < 0)
        Console.WriteLine("третья");
}
Console.WriteLine("первая к");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("вторая к");
int y1 = int.Parse(Console.ReadLine());
Chet(x1,y1);
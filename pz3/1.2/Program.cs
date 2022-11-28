double Chet(int ax, int ay,int bx, int by)
{
    double result;
    result = Math.Sqrt( Math.Pow(bx - ax,2) + Math.Pow(by - ay,2));
    return result;
}
Console.WriteLine("первая к a");
int ax = int.Parse(Console.ReadLine());
Console.WriteLine("вторая к a");
int ay = int.Parse(Console.ReadLine());
Console.WriteLine("вторая к b");
int bx = int.Parse(Console.ReadLine());
Console.WriteLine("вторая к b");
int by = int.Parse(Console.ReadLine());
Console.WriteLine(Math.Round(Chet(ax,ay,bx,by)));
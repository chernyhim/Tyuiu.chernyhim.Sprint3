using Tyuiu.chernyhim.Sprint3.Task6.V15.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("Input start value");
        int startvalue1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input stop value");
        int stopvalue1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Result "+ds.GetSumTheDivisors(startvalue1, stopvalue1));
    }
}
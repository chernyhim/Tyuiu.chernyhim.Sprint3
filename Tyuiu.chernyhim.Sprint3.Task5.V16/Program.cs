using Tyuiu.chernyhim.Sprint3.Task5.V16.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("Input x");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input start value1");
        int startvalue1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input stop value1");
        int stopvalue1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input start value2");
        int startvalue2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input stop value2");
        int stopvalue2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Result "+ds.GetSumSumSeries(x, startvalue1, startvalue2,stopvalue1,stopvalue2));
    }
}
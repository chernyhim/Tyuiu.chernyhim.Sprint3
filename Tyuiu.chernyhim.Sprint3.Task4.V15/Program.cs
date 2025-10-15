using Tyuiu.chernyhim.Sprint3.Task4.V15.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("Input start value");
        int startvalue = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input stop value");
        int stopvalue = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Result"+ds.Calculate(startvalue, stopvalue));
    }
}
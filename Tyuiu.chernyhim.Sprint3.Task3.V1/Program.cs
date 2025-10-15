using Tyuiu.chernyhim.Sprint3.Task3.V1.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("Input string");
        string str = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Input symbol");
        char item = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("Result" + ds.GetCharCount(str, item));
        
    }
}
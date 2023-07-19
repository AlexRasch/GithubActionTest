namespace Domain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine($"1 + 1 = {Calc.Sum(1,1)}");

            Console.ReadKey();
        }
    }
}
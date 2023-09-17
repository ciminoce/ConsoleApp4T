namespace ConsoleApp4t
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var celsius = 20;
            Console.WriteLine(ConvertToFah(celsius));
        }

        private static double ConvertToFah(double celsius) => 1.8 * celsius + 32;
        
    }
}
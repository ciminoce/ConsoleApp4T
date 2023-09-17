namespace ConsoleApp4t
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var celsius = 20;
            var fah = 69;
            Console.WriteLine(ConvertToFah(celsius));
            Console.WriteLine(ConvertToCelsius(fah));
        }

        private static double ConvertToCelsius(int fah) => (fah - 32) / 1.8f;
        

        private static double ConvertToFah(double celsius) => 1.8 * celsius + 32;
        
    }
}
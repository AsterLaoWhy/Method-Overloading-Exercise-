namespace MethodOverloading
{
    public class Program
    {
        static int Add(int x, int y)
        {
            return x+y;
        }
        static double Add(double x, double y)
        {
            return x + y;
        }
        static string Add(double x, double y, bool isDollar)
        {
            if (isDollar && x + y > 1) return $"{x + y} dollars";
            if (isDollar && x + y <= 1) return $"{x + y} dollar";
            return $"{x + y}";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}

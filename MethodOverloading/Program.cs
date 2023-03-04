using System.ComponentModel;

namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            //checking work for integer
            var a = 4;
            var b = 12;
            var intsum = Methods.add(a, b);
            //checking work for decimal
            var c = 3.45m;
            var d = 2.76m;
            var decsum = Methods.add(c, d);
            //checking work for dollars
            var dollarsum = Methods.add(a, b, true);

            Console.WriteLine($"The sum of the integers: {intsum}");
            Console.WriteLine($"The sum of the decimals: {decsum}");
            Console.WriteLine(dollarsum);
        }
    }
}

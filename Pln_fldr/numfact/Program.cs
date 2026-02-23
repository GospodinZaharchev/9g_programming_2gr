using System.Security.Cryptography.X509Certificates;

namespace numfact
{
    internal class Program
    {
        static int NumFact(int number, int fact)
        {
            int buffer = number;
            for (int i = 0; i < fact; i++)
            {
                number = number * buffer;
            }
            return number;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("how many times?");
            int fact = int.Parse(Console.ReadLine());
            Console.WriteLine("what to repeat?");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(NumFact(number, fact));
        }
    }
}

using System.Security.Cryptography.X509Certificates;

namespace repeatstring
{
    internal class Program
    {
        static void StringRepeater(int timesRepeat, string wordToBeRepeated)
        {
            for (int i = 0; i < timesRepeat; i++)
            {
                Console.Write(wordToBeRepeated);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("how many time?");
            int timesReapeat = int.Parse(Console.ReadLine());
            Console.WriteLine("what to repeat?");
            string wordToBeRepeated = Console.ReadLine();

            StringRepeater(timesReapeat, wordToBeRepeated);
        }
    }
}

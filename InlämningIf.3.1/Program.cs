using System;
namespace inlämning3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du?");
            int tal = int.Parse(Console.ReadLine());
            if (tal >= 16 && tal <= 19)
            {
                Console.WriteLine("Du får vara med");
            }
            else
            {
                Console.WriteLine("Du får inte vara med");
            }
        }
    }
}

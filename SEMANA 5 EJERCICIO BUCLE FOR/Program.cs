
namespace RangoPares
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorInicial;
            int valorFinal;

            Console.WriteLine("digite el valor inicial:");
            valorInicial = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite el valor final:");
            valorFinal = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Los números pares son: ");

            for (int i = valorInicial; i <= valorFinal; i += 2)
            {
                Console.Write(i + " ");
            }
        }
    }
}
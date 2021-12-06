using System;

namespace Boardinghouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] vect = new Student[10];

            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nAluguel {i}: ");
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int room = int.Parse(Console.ReadLine());
                vect[room] = new Student(name, email);
            }

            Console.WriteLine("\nQuartos ocupados: ");
            
            for(int i = 0; i < 10; i++)
            {
                if(vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
        }
    }
}

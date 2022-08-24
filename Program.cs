using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random resp = new Random();
            int num = resp.Next(1, 10);
            int respU;

            Console.WriteLine("Chute um numero de 1 a 10 humano burru: ");
            try
            {
                respU = int.Parse(Console.ReadLine());

                while (respU >= 0)
                {
                    if (respU == num)
                    {
                        Console.WriteLine("O numero da vez era: " + num);
                        Console.WriteLine("Você digitou: " + respU);
                        Console.WriteLine("----Parabéns!----");
                        break;
                    }

                    if (respU != num)
                    {
                        Console.WriteLine("\nA proximidade do seu numero é de: " + (Math.Abs(respU - num)));
                        Console.WriteLine("Você digitou: " + respU);
                        Console.WriteLine("Você errou!");

                        Console.WriteLine("\nTente novamente: \n");
                        respU = int.Parse(Console.ReadLine());
                        continue;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro na digitação, tente novamente");
            }
            Console.ReadKey();
        }
    }
}

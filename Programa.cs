using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args){

        int a, b, c;

            Console.WriteLine("Digite seu primeiro numero: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu segundo numero: ");
            b = int.Parse(Console.ReadLine());

            c = (a + b)/2;

            Console.WriteLine("Seu primeiro número: "+a+"\n Seu segundo número: "+b+"\n sua média é: "+c);

            if (c < 6)
            {
                Console.WriteLine("Sua média é abaixo de 6!!");
                c -= 10;
                
                Console.WriteLine("Para você chegar a uma média aceitavel é necessario: "+ Math.Abs(c));
            }
            Console.ReadKey();
        }
    }
}

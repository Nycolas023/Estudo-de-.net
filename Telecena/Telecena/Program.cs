using System;

namespace Telecena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            string b, bl = "sim";
            Random rdn = new Random();

            while (bl == "sim" || bl == "s"){
                try{
                    Console.WriteLine("Coloque quantos números da telecena quer sortear: ");
                    a = int.Parse(Console.ReadLine());
                    for (int i = 0; i < a; i++){
                        Console.WriteLine("Seu " + (i + 1) + "º número é: " + rdn.Next(1, 60));
                    }

                    Console.WriteLine("\nDeseja continuar? ");
                    b  = Console.ReadLine();
                    bl = b.ToLower();
                    

                    if (bl != "sim" && bl != "s")
                    {
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                catch (Exception ex){
                    Console.WriteLine("\nEscreva um número inteiro ou não digite teclas");
                    }
                }
            }
        }
    }
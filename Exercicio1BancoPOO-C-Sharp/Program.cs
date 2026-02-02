using System;
using System.Globalization;

namespace Exercicio1BancoPOO_C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria c;
            double valor = 0.0; 

            Console.Write("Entre o número da conta: ");
            int num = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s / n)? ");
            char res = char.Parse(Console.ReadLine());
            res = Char.ToUpper(res);

            //Console.WriteLine(res);
            if(res == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c = new ContaBancaria(num, titular, valor);
                Console.WriteLine("\nDados da Conta: ");
                Console.WriteLine(c);
            }
            else
            {
                c = new ContaBancaria(num,titular);
                Console.WriteLine("\nDados da Conta: ");
                Console.WriteLine(c);
            }

            Console.Write("Entre um valor para depósito: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Deposito(valor);

            Console.WriteLine("\nDados da conta atualizados:");
            Console.WriteLine(c);

            Console.Write("Entre um valor para saque: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Saque(valor);

            Console.WriteLine("\nDados da conta atualizados:");
            Console.WriteLine(c);

        }
    }
}

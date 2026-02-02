using System;
using System.Drawing;
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;

namespace Exercicio1BancoPOO_C_Sharp
{
    internal class ContaBancaria
    {
        public string Titular { get; set; } 
        public int Numero { get; private set; }
        public double Saldo { get; private set;}

        public ContaBancaria(int n, string t)
        {
            Titular = t;
            Numero = n; 
        }

        public ContaBancaria(int num, string titular, double DepositoInicial) : this(num, titular)
        {
            Deposito(DepositoInicial); 
        }

        public void Deposito(double DepositoInicial)
        {
            Saldo += DepositoInicial; 
        }

        public void Saque(double valor)
        {
            Saldo -= valor + 5.00; 
        }


        public override string ToString()
        {
            return "Conta: " + Numero 
                + ", Titular: " +Titular
                + ", Saldo: $ " + Saldo.ToString("F2",CultureInfo.InvariantCulture);
            //Conta 7801, Titular: Maria Brown, Saldo: $ -3.00
        }
    }
}

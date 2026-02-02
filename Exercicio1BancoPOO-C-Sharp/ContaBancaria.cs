using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio1BancoPOO_C_Sharp
{
    internal class ContaBancaria
    {
        public string Titular { get; set; } 
        public int Numero { get; private set; }
        public double Saldo { get; private set;}

        public ContaBancaria(string t, int n)
        {
            Titular = t;
            Numero = n; 
        }




    }
}

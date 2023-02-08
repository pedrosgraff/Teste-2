using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    internal class Conta
    {

        public double _conta { get; private set; }
        public string _nome { get; set; }
        public double Saldo { get; private set; }


        public Conta(double conta, string nome)
        {
            _conta = conta;
            _nome = nome;
            Saldo = 0;
        }
        public Conta(double conta, string nome, double saldo) : this(conta, nome)
        {
            Saldo = saldo;
        }

        public void Deposito(double quantiaE)
        {
            Saldo += quantiaE;
        }

        public void Saque(double quantiaS)
        {
            Saldo += quantiaS;
        }

        public override string ToString()
        {
            return "Conta: " + _conta + ", Titular: " + _nome + ", Saldo:" + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
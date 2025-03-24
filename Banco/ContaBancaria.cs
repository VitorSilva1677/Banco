using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class ContaBancaria
    {
        private int _numero;
        private string _titular;
        private double _saldo;
        private 
        public int Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

        public string Titular
        {
            get { return _titular; }
            set { _titular = value; }
        }
        public double Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }
        
        public ContaBancaria(int numeroConta, string titular, double saldoInicial)
        {
            Numero = numeroConta;
            Titular = titular;
            Saldo = saldoInicial;
        }
        public double Depositar(double valor)
        {
            Saldo += valor * (1 + PercentualBonusDeposito / 100);
            return Saldo;
        }

        public double Sacar (double valor)
        {
            Saldo -=(valor);
            return Saldo;
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Seu saldo éw {Saldo}");
        }
    }
}

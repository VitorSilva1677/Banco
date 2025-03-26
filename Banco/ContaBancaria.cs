using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class ContaBancaria
    {
        private int _numerocom;
        private string _titular;
        private double _saldo;
        private double _taxa;
        private double _percentual;
        public int Numero
        {
            get { return _numerocom;}
            set { _numerocom = value;}
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
        protected double Taxa
        {
            get { return _taxa; }
            set { _taxa = value; }
        }
        protected double Percentual
        {
            get { return _percentual; }
            set { _percentual = value; }
        }
        
        public ContaBancaria(int numeroConta, string titular, double saldoInicial)
        {
            Numero = numeroConta;
            Titular = titular;
            Saldo = saldoInicial;
        }
        public double Depositar(double valor)
        {
            Saldo += valor * (1 + Percentual/100);
            return Saldo;
        }

        public double Sacar (double valor)
        {
            Saldo -=(valor + Taxa);
            return Saldo;
        }

        public void ExibirSaldo()
        {
            Console.WriteLine(Titular);
            Console.WriteLine($"Seu saldo é {Saldo}");
        }
    }
}

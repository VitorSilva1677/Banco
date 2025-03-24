using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class ContaPoupanca
    {
        public class ContaPoupanca : ContaBancaria
        {
            public ContaPoupanca(int numeroConta, string titular, double saldoInicial) : base (numeroConta, titular, saldoInicial)
            {
                TaxaSaque = 5;
            }
        }
    }
}

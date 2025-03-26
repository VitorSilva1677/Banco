namespace Banco
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int looping = 0;
            int repeticao = 0;
            List<ContaCorrente> ccConta = new List<ContaCorrente>();
            List<ContaPoupanca> cpConta = new List<ContaPoupanca>();
            Console.WriteLine("1 - Corrente");
            Console.WriteLine("2 - Poupança");
            int opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    while(looping == 0)
                    {
                        Opcoes();
                        opcao = int.Parse(Console.ReadLine());
                        switch (opcao)
                        {
                                case 1:
                                    Console.WriteLine("Digite seu nomne: ");
                                    string nome = Console.ReadLine();
                                    Console.WriteLine("Qual o seu saldo?");
                                    double saldo = double.Parse(Console.ReadLine());
                                    int numConta = ccConta.Count() + 1;
                                    ContaCorrente contacc = new ContaCorrente(numConta, nome, saldo);
                                    ccConta.Add(contacc);
                                    break;

                                case 2:
                                    foreach (var conta in ccConta)
                                    {
                                        Console.WriteLine(conta.Numero);
                                    }
                                    int escolha = int.Parse(Console.ReadLine());
                                    contacc = ccConta.FirstOrDefault(x => x.Numero == escolha);
                                    if (contacc == null)
                                    {
                                        Console.WriteLine("Conta indisponível");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Insira o valor que deseja sacar: ");
                                        double saque = double.Parse(Console.ReadLine());
                                        contacc.Sacar(saque);
                                    }
                                    break;

                                case 3:
                                    foreach (var conta in ccConta)
                                    {
                                        Console.WriteLine(conta.Numero);
                                    }
                                    escolha = int.Parse(Console.ReadLine());
                                    contacc = ccConta.FirstOrDefault(x => x.Numero == escolha);
                                    if (contacc == null)
                                    {
                                        Console.WriteLine("Conta indisponível");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Insira o valor que queira depositar: ");
                                        double deposito = double.Parse(Console.ReadLine());
                                        contacc.Depositar(deposito);
                                    }
                                    break;

                                case 4:
                                    Console.WriteLine("Conta corrente: ");
                                    foreach (var conta in ccConta)
                                    {
                                        Console.WriteLine(conta.Numero);
                                    }
                                    escolha = int.Parse(Console.ReadLine());
                                    contacc = ccConta.FirstOrDefault(x => x.Numero == escolha);
                                    if (contacc == null)
                                    {
                                        Console.WriteLine("Conta indisponível");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Conta nª {contacc.Numero}");
                                        Console.WriteLine($"Nome: {contacc.Titular}");
                                        Console.WriteLine($"Saldo: {contacc.Saldo}");
                                        Console.WriteLine("Digite 0 para continuar ou outro número para sair.");
                                        looping = int.Parse(Console.ReadLine());
                                    }
                                    break;

                                default:
                                    Console.WriteLine("Número inválido");
                                    break;
                        }
                  
                }
                    break;
                case 2:
                    while (looping == 0)
                    {


                        Opcoes();
                        opcao = int.Parse(Console.ReadLine());
                        switch (opcao)
                        {
                            case 1:
                                Console.WriteLine("Digite seu nomne: ");
                                string nome = Console.ReadLine();
                                Console.WriteLine("Qual o seu saldo?");
                                double saldo = double.Parse(Console.ReadLine());
                                int numConta = cpConta.Count() + 1;
                                ContaPoupanca contacp = new ContaPoupanca(numConta, nome, saldo);
                                cpConta.Add(contacp);

                                break;

                            case 2:
                                foreach (var conta in ccConta)
                                {
                                    Console.WriteLine(conta.Numero);
                                }
                                int escolha = int.Parse(Console.ReadLine());
                                contacp = cpConta.FirstOrDefault(x => x.Numero == escolha);
                                if (contacp == null)
                                {
                                    Console.WriteLine("Conta indisponível");
                                }
                                else
                                {
                                    Console.WriteLine("Insira o valor que deseja sacar: ");
                                    double saque = double.Parse(Console.ReadLine());
                                    contacp.Sacar(saque);
                                }
                                break;

                            case 3:
                                foreach (var conta in ccConta)
                                {
                                    Console.WriteLine(conta.Numero);
                                }
                                escolha = int.Parse(Console.ReadLine());
                                contacp = cpConta.FirstOrDefault(x => x.Numero == escolha);
                                if (contacp == null)
                                {
                                    Console.WriteLine("Conta indisponível");
                                }
                                else
                                {
                                    Console.WriteLine("Insira o valor que queira depositar: ");
                                    double deposito = double.Parse(Console.ReadLine());
                                    contacp.Depositar(deposito);
                                }
                                break;

                            case 4:
                                Console.WriteLine("Conta corrente: ");
                                foreach (var conta in ccConta)
                                {
                                    Console.WriteLine(conta.Numero);
                                }
                                escolha = int.Parse(Console.ReadLine());
                                contacp = cpConta.FirstOrDefault(x => x.Numero == escolha);
                                if (contacp == null)
                                {
                                    Console.WriteLine("Conta indisponível");
                                }
                                else
                                {
                                    Console.WriteLine($"Conta nª {contacp.Numero}");
                                    Console.WriteLine($"Nome: {contacp.Titular}");
                                    Console.WriteLine($"Saldo: {contacp.Saldo}");
                                    Console.WriteLine("Digite 0 para continuar ou outro número para sair.");
                                    looping = int.Parse(Console.ReadLine());
                                }
                                break;

                            default:
                                Console.WriteLine("Número inválido");
                                break;
                        }
                       
                    }
                    break;
            }

            static void Opcoes()
            {
                Console.WriteLine("1- Criar conta");
                Console.WriteLine("2- Sacar");
                Console.WriteLine("3- Depositar");
                Console.WriteLine("4- Mostrar conta");
            }
        }
    } }
using System;
using System.Threading;

class Program
{
    public static void Main(string[] args)
    {
        float[] saque = new float[100];
        float[] deposito = new float[100];
        float[] transferencia = new float[100];
        string[] contas = new string[100];
        float[] saldo = new float[100];
        int vezes = 0;
        int x = 0, i = 0, j = 0, k = 0;
        bool sair = false;

        Console.Clear();
        Console.WriteLine("Bem vindo");
        Thread.Sleep(3000);

        while (!sair)
        {
            Console.Clear();
            Console.Write("Insira o número da sua conta (5 dígitos): ");
            contas[x] = Console.ReadLine();

            while (contas[x].Length != 5)
            {
                Console.WriteLine("O número precisa ter 5 dígitos.");
                Thread.Sleep(2000);
                Console.Clear();
                Console.Write("Insira o número da sua conta (5 dígitos): ");
                contas[x] = Console.ReadLine();
            }

            bool trocouConta = false;
            while (!trocouConta && !sair)
            {
                Console.Clear();
                Console.WriteLine("\nEscolha a operação desejada:\n");
                Console.WriteLine("[1] Verificar saldo\n[2] Saque\n[3] Depósito\n[4] Transferência\n[5] Extrato\n[6] Trocar de conta\n[7] Sair");
                Console.Write("\n> ");
                if (int.TryParse(Console.ReadLine(), out int opcao))
                {
                    switch (opcao)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine($"Seu saldo é de R$ {saldo[x]:F2}");
                            break;

                        case 2:
                            Console.Clear();
                            Console.Write("Digite o valor do saque (Limite de R$ 1000): ");
                            if (float.TryParse(Console.ReadLine(), out saque[i]) && saque[i] > 0 && saque[i] <= 1000 && saque[i] <= saldo[x])
                            {
                                saldo[x] -= saque[i];
                                Console.WriteLine($"Saque realizado: R$ {saque[i]:F2}. Saldo restante: R$ {saldo[x]:F2}");
                                i++;
                                vezes++;
                            }
                            else
                            {
                                Console.WriteLine("Erro: valor inválido ou saldo insuficiente.");
                            }
                            break;

                        case 3:
                            Console.Clear();
                            Console.Write("Digite o valor do depósito: ");
                            if (float.TryParse(Console.ReadLine(), out deposito[j]) && deposito[j] > 0)
                            {
                                saldo[x] += deposito[j];
                                Console.WriteLine($"Depósito realizado: R$ {deposito[j]:F2}");
                                j++;
                                vezes++;
                            }
                            else
                            {
                                Console.WriteLine("Erro: valor inválido.");
                            }
                            break;

                        case 4:
                            Console.Clear();
                            Console.Write("Digite o valor da transferência: ");
                            if (float.TryParse(Console.ReadLine(), out transferencia[k]) && transferencia[k] > 0 && transferencia[k] <= saldo[x])
                            {
                                string contaTransf;
                                do
                                {
                                    Console.Write("Insira o número da conta para qual deseja transferir (5 dígitos): ");
                                    contaTransf = Console.ReadLine();
                                } while (contaTransf.Length != 5);

                                int contaDestinoIndex = Array.IndexOf(contas, contaTransf);
                                if (contaDestinoIndex >= 0)
                                {
                                    saldo[x] -= transferencia[k];
                                    saldo[contaDestinoIndex] += transferencia[k];
                                    Console.WriteLine($"Transferência de R$ {transferencia[k]:F2} realizada para a conta {contaTransf}.");
                                    k++;
                                    vezes++;
                                }
                                else
                                {
                                    Console.WriteLine("Erro: conta de destino não encontrada.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Erro: valor inválido ou saldo insuficiente.");
                            }
                            break;

                        case 5:
                            Console.Clear();
                            Console.WriteLine("Extrato:");
                            for (int l = 0; l < vezes; l++)
                            {
                                Console.WriteLine($"\nConta: {contas[l]}");
                                Console.WriteLine($"Saldo: R$ {saldo[l]:F2}");
                                if (saque[l] > 0) Console.WriteLine($"Saque: R$ {saque[l]:F2}");
                                if (deposito[l] > 0) Console.WriteLine($"Depósito: R$ {deposito[l]:F2}");
                                if (transferencia[l] > 0) Console.WriteLine($"Transferência: R$ {transferencia[l]:F2} para a conta {contas[l]}");
                            }
                            break;

                        case 6:
                            Console.Clear();
                            x++;
                            trocouConta = true;
                            break;

                        case 7:
                            sair = true;
                            break;

                        default:
                            Console.WriteLine("Opção inválida.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Erro: entrada inválida.");
                }

                if (!trocouConta && !sair)
                {
                    Console.Write("\nDeseja realizar outra operação? [1] Sim / [2] Não: ");
                    if (!int.TryParse(Console.ReadLine(), out int continuar) || continuar != 1)
                    {
                        trocouConta = true;
                        sair = true;
                    }
                }
            }
        }

        Console.WriteLine("\nObrigado por utilizar nossos serviços.");
        Console.WriteLine("Encerrando sistema.");
        Thread.Sleep(3000);
        Console.Clear();
    }
}

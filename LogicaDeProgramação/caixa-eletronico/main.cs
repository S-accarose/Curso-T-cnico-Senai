using System;

class Program {
  public static void Main (string[] args) {
    
    float saldo = 0;
    int resposta;
    float[] saque = new float[100];
    float[] deposito = new float[100];
    float[] transferencia = new float[100];
    string[] num = new string[100];
    int vezes = 0;
    
    repetir:
    Console.WriteLine ("Bem vindo");
    Console.Write("\nEscola a operação desejada :\n\n[1] Verificar saldo    [2] Saque\n[3] Depósito    [4] Tranferência\n[5] Extrato    [6] Sair\n\n>");
    if(!int.TryParse(Console.ReadLine(), out int a))
    {
      Console.WriteLine("\nOpção inválida.");
      goto repetir;
    }
    switch(a)
    {
      case 1:
        Console.WriteLine($"\nSeu saldo é de {saldo:F2}");
        Console.Write("\nDeseja realizar mais alguma operação? [1] Sim / [2] Não  > ");
      if(int.TryParse(Console.ReadLine(), out resposta) && resposta == 1)
      {
        goto repetir;
      }
      break;
      case 2:
      for(int i = 1; i < 100; i++)
      {
        Console.Write("\nDigite o valor do saque: ");
        if(float.TryParse(Console.ReadLine(), out saque[i]) && saque[i] > 0)
        {
            Console.WriteLine($"\nO valor remasnescente é {saldo:F2}. Você sacou : {saque[i]:F2}.");
            saldo = saldo - saque[i];
            vezes++;
        }
        else
        {
          Console.WriteLine("\nErro, saldo insuficiente ou valor inválido.");
          goto repetir;
        }
          Console.Write("\nDeseja realizar mais alguma operação? [1] Sim / [2] Não  > ");
        if(int.TryParse(Console.ReadLine(), out resposta) && resposta == 1)
        {
          goto repetir;
        }
      }
      break;
      
      case 3:
      for(int i = 1; i < 100; i++)
      {
        Console.Write("\nDigite o valor do saque: ");
        if(float.TryParse(Console.ReadLine(), out deposito[i]) && deposito[i] > 0)
        {
          Console.WriteLine($"\nVocê depositou : {deposito[i]:F2}.");
          saldo = saldo + deposito[i];
          vezes++;
        }
        else
        {
          Console.WriteLine("\nErro, valor inválido.");
          goto repetir;
        }
          Console.Write("\nDeseja realizar mais alguma operação? [1] Sim / [2] Não  > ");
        if(int.TryParse(Console.ReadLine(), out resposta) && resposta == 1)
        {
          goto repetir;
        }
      }
      break;

      case 4:
      for(int i = 1; i < 100; i++)
      {
        Console.Write("\nDigite o valor da transferencia: ");
        if(float.TryParse(Console.ReadLine(), out transferencia[i]) && transferencia[i] > 0)
        {
          Console.Write("\nInsira o número da conta para qual deseja transferir > ");
          num[i] = Console.ReadLine();
          Console.WriteLine($"\nVocê Transferiu: {transferencia[i]:F2} para a conta de número {num}.");
          vezes++;
        }
        else
        {
          Console.WriteLine("\nErro, valor inválido.");
          goto repetir;
        }
          Console.Write("\nDeseja realizar mais alguma operação? [1] Sim / [2] Não  > ");
        if(int.TryParse(Console.ReadLine(), out resposta) && resposta == 1)
        {
          goto repetir;
        }
      }
      break;

      case 5:
      Console.Write("\nDeseja consultar o extrato? [1] Sim / [2] Não  > ");
      if(int.TryParse(Console.ReadLine(), out resposta) && resposta == 1)
      {
        if (saque.Length > 0 || deposito.Length > 0 || transferencia.Length > 0)
        {
          for(int i = 1; i <= vezes; i++)
          {
            Console.WriteLine($"\nExtrato:\n Saldo: {saldo:F2}\n Saque: {saque[i]:F2}\n Depósito: {deposito[i]:F2}\n Transferência: {transferencia[i]:F2} para a conta de número {num[i]}.");
          }
        } 
        else
        {
          Console.WriteLine("Seu extrato está vazio.");
          goto repetir;
        }
      }
      else
      {
        goto repetir;
      }
      Console.Write("\nDeseja realizar mais alguma operação? [1] Sim / [2] Não  >");
      if(int.TryParse(Console.ReadLine(), out resposta) && resposta == 1)
      {
        goto repetir;
      }
      break;

      case 6:
      Console.WriteLine("\nObrigado por utilizar nossos serviços.");
      Console.WriteLine("\nEncerrando sistema.");
      break;
    }
  }
}
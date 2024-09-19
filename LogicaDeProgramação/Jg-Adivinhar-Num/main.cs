using System;

class Program 
{
  public static void Main (string[] args) 
  {
    Random rng = new Random();
    int rand1 = rng.Next(101);
    Console.WriteLine ("Jogo de adivinhação de número\x0A");
    for(int i = 1; i <= 1000; i++)
    {
      Console.Write ("Insira o seu palpite : ");
      if(int.TryParse(Console.ReadLine(), out int palpite))
      {
        if (palpite == rand1)
        {
          Console.WriteLine($"\x0AParabéns, você acertou o número!\x0AO número era {rand1}. Foram necessárias {i} tentativas para acertar.");
          i=1000;
        }
        else if(palpite > rand1)
        {
          Console.WriteLine("\x0AVocê errou, o número é menor que o seu palpite\x0A");
        }
        else
        {
          Console.WriteLine("\x0AVocê errou, o número é maior que o seu palpite\x0A");
        }
      }
      else
      {
        Console.WriteLine("\x0AInsira um número válido\x0A");  
      }
    }
  }
}
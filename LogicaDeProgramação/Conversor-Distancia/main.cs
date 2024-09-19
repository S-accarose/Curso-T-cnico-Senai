using System;

class Program {
  public static void Main (string[] args) {
    Console.Write ("Digite o valor em metros: ");
    if(double.TryParse(Console.ReadLine(), out double metros))
    {
      Console.Write("Deseja transformar em Centimetros(cm), Quilômetros(km) ou Milhas(mi): ");
      string conversao = Console.ReadLine();
      switch(conversao)
      {
      case "cm":
        Console.WriteLine($"O valor em centimetros é {(metros * 100):F2} Cm");
      break;
      case "km":
          Console.WriteLine($"O valor em quilômetro é {(metros / 1000):F2} Km");
        break;
      case "mi":
        Console.WriteLine($"O valor em milhas é {(metros/1609.344):F2} Mi");
      break;
      }
    }
    else
    {
      Console.WriteLine("Valor invalido");  
    }
  }
}
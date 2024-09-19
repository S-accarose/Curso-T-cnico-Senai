using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Tabuada\x0A");
    Console.WriteLine ("Digite um número para gerar a tabuada:\x0A");
    int num = int.Parse(Console.ReadLine());
    Console.WriteLine("\x0A");
    for(int a = 0; a <= 10; a++){
      Console.WriteLine(num + " x " + a + " = " + num * a);
    }
  }
}
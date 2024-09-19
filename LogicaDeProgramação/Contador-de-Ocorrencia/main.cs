using System;

class Program {
  public static void Main (string[] args) {
    int num = 0;
    Console.WriteLine ("Contador de repetição de letra.");
    Console.WriteLine ("\x0AInsira uma palavra :");
    string a = Console.ReadLine();
    Console.WriteLine ("\x0AInsira uma letra :");
    char b = Console.ReadLine()[0];
    foreach(char lett in a){
      if(lett == b){
        num++;
      }
    }
    Console.WriteLine ("\x0A A letra "+b+" aparece "+num+" vezes!");
  }
}
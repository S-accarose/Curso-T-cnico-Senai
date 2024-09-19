using System;
using System.Collections.Generic;
using System.IO;

class Program
{

    public static void Main(string[] args)
    {

        using (StreamWriter escrever = new StreamWriter("Jogos-mega.txt"))
        {
            Console.WriteLine(" Aleatorizar Mega-Sena\x0A");
        val:
            Console.Write(" Qual o valor do prêmio? ");
            if (!int.TryParse(Console.ReadLine(), out int premio))
            {
                Console.WriteLine(" Valor inválido!");
                goto val;
            }
            Console.Write($"\x0A 75% do prêmio será dividido aos que acertarem às 6 dezenas, equivalente a : {premio * 0.75:F2} \x0A 15% Para quem acertar 5 dezenas, equivalente a : {premio * 0.15:F2} \x0A 10% Para quem acertar 4 dezenas, equivalente a : {premio * 0.10:F2}");

        repeat1:
            Console.Write("\x0A\x0A Quantos jogos deseja fazer? ");
            if (!int.TryParse(Console.ReadLine(), out int qj))
            {
                Console.WriteLine("\x0A Insira apenas números");
                goto repeat1;
            }
        repeat:
            Console.Write("\x0A Quantas dezenas por jogo? ");
            if (!int.TryParse(Console.ReadLine(), out int d))
            {
                Console.WriteLine("\x0A Insira apenas números");
                goto repeat;
            }
            if (d < 6 || d > 15)
            {
                Console.WriteLine("\x0A Número inválido! O número de dezenas deve estar acima de 6 e abaixo de 15.");
                goto repeat;
            }
            else
            {
                if (qj > 0)
                {
                    for (int a = 1; a <= qj; a++)
                    {
                        Console.Write("\x0A" + a + "º jogo: ");
                        HashSet<int> un = new HashSet<int>();
                        string num = "";
                        for (int b = 1; b <= d; b++)
                        {
                            int rn;
                            do
                            {
                                rn = new Random().Next(1, 61);
                            } while (!un.Add(rn));

                            if (b > 1)
                            {
                                num += "-";
                            }
                            num += rn.ToString("D2");
                        }
                        Console.WriteLine(num);
                        escrever.WriteLine(num);
                    }
                }
                else
                {
                    Console.WriteLine("\x0A Número inválido! O número de jogos deve ser maior que 0.\x0A");
                    goto repeat1;
                }
            }
        }
    }
}
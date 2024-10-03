using System;

class Program {
  public static void Main (string[] args) {
    bool reservatorio = true;
    int boiab = 15;
    int boiaa = 5;
    int boiac = 13;
    int resev1 = 0;
    int resev2 = 0;
    int maxresev1 = 20;
    int maxresev2 = 15;
    
    repetir:
    Console.Write("\nO reservatório possui água? (s)/(n) > ");
    if(!char.TryParse(Console.ReadLine(), out char sn))
    {
      Console.WriteLine("\nValor inválido");
      goto repetir;
    }

    if(!(sn == 's'))
    {
      Console.WriteLine("\nReservatorio vazio.");
      resev1 = 0;
      resev2 = 0;
      reservatorio = false;
    }
    else
    {
      repetir1:
      Console.Write("\nQual o nivel de água no reservatório 1? ");
      if(!int.TryParse(Console.ReadLine(), out resev1))
      {
        Console.WriteLine("\nValor inválido");
        goto repetir1;
      }
      repetir2:
      Console.Write("\nQual o nivel de água no reservatório 2 da boia C? ");
      if(!int.TryParse(Console.ReadLine(), out resev2))
      {
        Console.WriteLine("\nValor inválido");
        goto repetir2;
      }
    }

    Console.Clear();
    
    if(resev2 < boiac && reservatorio != false)
    {
      Console.WriteLine("\nLigar bomba d'água.");
    }
    
    if(resev1 < maxresev1 && resev1 < boiaa || resev2 < maxresev2)
    {
      if(reservatorio == true)
      {
        Console.WriteLine("\nLigar Bomba d'água.");
      }
      
      do
      {
        resev1++;
        Console.WriteLine($"\nEnchendo o reservatório 1 : {resev1}");
      }while(resev1 < maxresev1);

      if(resev1 >= boiab)
      {
        do
        {
          Console.WriteLine("\nLigar eletroválvula.");

          repetirformat:
          resev2++;
          if(resev1>=boiab)
          {
            resev1--;
          }
          else if(resev1 > 15)
          {
            Console.WriteLine("\nA eletroválvula se desligou.");
            break;
          }
          Console.WriteLine($"\nEnchendo o reservatório 2 : Do reservatório 1 >{resev1} para o reservatório 2 >{resev2}");
          if(resev2 >= maxresev2)
          {
            Console.WriteLine("\nA eletroválvula se desligou.");
            break;
          }
          goto repetirformat;
        }while(resev2 < maxresev2);
      }
    
      if(resev2==maxresev2)
      {
        Console.WriteLine($"\nO reservatório 2, da boia C, encheu: {resev2} (capacidade máxima de {maxresev2}).");
        Console.WriteLine($"\nReservatório 1 se manteve com: {resev1} (capacidade máxima de {maxresev1}).");
      }
      else if(resev1==maxresev1)
      {
        Console.WriteLine($"\nO reservatório 1 encheu: {resev1} (capacidade máxima de {maxresev1}).");
      }
    }
  }
}
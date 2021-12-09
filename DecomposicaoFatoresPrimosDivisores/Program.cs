using NumerosPrimosEDivisores;
using System;
using System.Collections.Generic;

namespace DecomposicaoFatoresPrimosDivisores
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Decomposição em fatores primos e número de divisores");
      Console.WriteLine("----------------------------------------------------");
      Console.WriteLine("");
      Console.Write("Digite um Numero: ");

      var numero = Console.ReadLine();

      try
      {
        if(!EhNumeroValido(numero)) throw new FormatException();

        Console.WriteLine("");
        Console.WriteLine("------------------------");
        Console.WriteLine("");

        var divisores = DecomposicaoNumerosPrimosDivisores.DecomporDivisores(int.Parse(numero));

        Show(TipoNumero.Divisores, divisores);

        var primos = DecomposicaoNumerosPrimosDivisores.DecomporNumeroPrimos(int.Parse(numero));

        Show(TipoNumero.Primos, primos);

        Console.ReadKey();
        Console.Clear();
        Main();
      }
      catch (FormatException e)
      {
        Console.WriteLine("O valor digitado não é um número entre 1 e 100.000.000");
        Console.WriteLine(e.Message);
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }
    }

    private static void Show(TipoNumero tipoNumero, List<int> listaNumerica)
    {
      switch (tipoNumero)
      {
        case TipoNumero.Divisores:
          Console.Write("Números Divisores: ");
          break;
        case TipoNumero.Primos:
          Console.WriteLine("");
          Console.WriteLine("");
          Console.Write("Números Primos: ");
          break;
      }

      foreach (int valor in listaNumerica)
      {
        Console.Write("{0:D} ", valor);
      }
    }

    private static bool EhNumeroValido(string numero)
    {
      return (int.Parse(numero) > 1 && int.Parse(numero) <= 100000000) ? true : false;
    }
  }
}

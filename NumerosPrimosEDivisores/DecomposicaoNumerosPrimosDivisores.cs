using System;
using System.Collections.Generic;
using System.Linq;

namespace NumerosPrimosEDivisores
{
  public static class DecomposicaoNumerosPrimosDivisores
  {
    public static List<int> DecomporDivisores(int dividendo)
    {
      var numerosDivisores = new List<int>() { };

      var metadeDividendo = (dividendo % 2 == 0) ? dividendo / 2 : (int)(dividendo / 2) + 1;

      for (var numeroNatural = 1; numeroNatural <= metadeDividendo; numeroNatural++)
      {
        if ((dividendo % numeroNatural).Equals(0)) numerosDivisores.Add(numeroNatural);
      }

      numerosDivisores.Add(dividendo);

      return numerosDivisores;
    }

    public static List<int> DecomporNumeroPrimos(int dividendo)
    {
      var numerosPrimos = new List<int>() { };
      var decomposicao = new List<int>() { 1 };
      var divisor = 2;
      var quociente = 0;

      do
      {
        if ((dividendo % divisor).Equals(0))
        {
          quociente = (dividendo / divisor);
          dividendo = quociente;
          decomposicao.Add(divisor);
        }
        else
        {
          divisor++;
        }

      } while (quociente != 1);

      numerosPrimos = decomposicao.Distinct().ToList();

      return numerosPrimos;
    }
  }
}

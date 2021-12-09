using NumerosPrimosEDivisores;
using NUnit.Framework;
using System.Collections.Generic;

namespace DecomposicaoFatoresPrimosDivisores.NUnit
{
  public class FatoresPrimosDivisioresTests
  {
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void DecomporDivisores()
    {
      var t1RespostaValida = DecomposicaoNumerosPrimosDivisores.DecomporDivisores(18);
      var t1RespostaEsperada = new List<int>() { 1, 2, 3, 6, 9, 18 };
      Assert.AreEqual(t1RespostaValida, t1RespostaEsperada);

      var t2RespostaValida = DecomposicaoNumerosPrimosDivisores.DecomporDivisores(45);
      var t2RespostaEsperada = new List<int>() { 1, 3, 5, 9, 15, 45 };
      Assert.AreEqual(t2RespostaValida, t2RespostaEsperada);
    }

    [Test]
    public void DecomporNumeroPrimos()
    {
      var t1RespostaValida = DecomposicaoNumerosPrimosDivisores.DecomporNumeroPrimos(45);
      var t1RespostaEsperada = new List<int>() { 1, 3, 5 };
      Assert.AreEqual(t1RespostaValida, t1RespostaEsperada);
    }
  }
}
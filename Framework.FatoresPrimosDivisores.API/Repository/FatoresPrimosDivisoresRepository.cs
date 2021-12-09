using NumerosPrimosEDivisores;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Challenge.FatoresPrimosDivisores.API.Repository
{
  public class FatoresPrimosDivisoresRepository : IFatoresPrimosDivisoresRepository
  {

    public async Task<List<int>> DecomporDivisores(int dividendo)
    {
        return DecomposicaoNumerosPrimosDivisores.DecomporDivisores(dividendo);
    }

    public async Task<List<int>> DecomporNumeroPrimos(int dividendo)
    {
      return DecomposicaoNumerosPrimosDivisores.DecomporNumeroPrimos(dividendo);
    }
  }
}

using System.Collections.Generic;
using System.Threading.Tasks;

namespace Challenge.FatoresPrimosDivisores.API.Repository
{
  public interface IFatoresPrimosDivisoresRepository
  {
    Task<List<int>> DecomporDivisores(int dividendo);
    Task<List<int>> DecomporNumeroPrimos(int dividendo);
  }
}

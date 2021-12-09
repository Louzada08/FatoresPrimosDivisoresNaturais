using Challenge.FatoresPrimosDivisores.API.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Challenge.FatoresPrimosDivisores.API.Controllers
{
  [ApiController]
  [ApiVersion("1")]
  [Route("api/[controller]/v{version:apiVersion}")]
  public class FatoresPrimosDivisoresController : Controller
  {
    private readonly IFatoresPrimosDivisoresRepository _fatoresRepository;

    public FatoresPrimosDivisoresController(IFatoresPrimosDivisoresRepository fatoresRepository)
    {
      _fatoresRepository = fatoresRepository;
    }

    [HttpGet("divisores/{numeroNatural}")]
    public async Task<List<int>> ObterDivisores(int numeroNatural)
    {
      return await _fatoresRepository.DecomporDivisores(numeroNatural);
    }

    [HttpGet]
    [Route("numerosprimos/{numeroNatural}")]
    public async Task<List<int>> ObterPrimos(int numeroNatural)
    {
      return await _fatoresRepository.DecomporNumeroPrimos(numeroNatural);
    }
  }
}

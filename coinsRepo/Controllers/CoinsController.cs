using coinsRepo.Models;
using coinsRepo.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coinsRepo.Controllers
{
    [Route("api/coins")]
    [ApiController]
    public class CoinsController : ControllerBase
    {
        private readonly ILogger<CoinsController> _logger;
        private readonly CoinsService _coins;
        public CoinsController(ILogger<CoinsController> logger, CoinsService coins)
        {
            _logger = logger;
            _coins = coins;

        }


        [HttpGet("search")]
        public Task<Dictionary<string, Data>> FindRepositoriesByNameAsync()
        {
            return _coins.FindCoinListAsync();
        }
    }
}

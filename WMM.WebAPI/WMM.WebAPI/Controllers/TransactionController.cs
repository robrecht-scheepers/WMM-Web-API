using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WMM.WebAPI.Services;

namespace WMM.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly TransactionService _service;

        public TransactionController(TransactionService transactionService)
        {
            _service = transactionService;
        }

        [HttpGet]
        public async Task<ActionResult<List<TransactionController>>> Get()
        {
            return Ok(await _service.Get());
        }
    }
}

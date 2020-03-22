using Microservices.Banking.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankingController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public BankingController(IAccountService accountService)
        {
            this._accountService = accountService;
        }

        // GET api/banking
        [HttpGet]
        public IActionResult GetAccounts()
        {
            var accounts = _accountService.GetAccounts();
            return Ok(accounts);
        }
        
    }
}

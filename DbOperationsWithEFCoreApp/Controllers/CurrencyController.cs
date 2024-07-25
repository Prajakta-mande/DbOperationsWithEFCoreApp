using DbOperationsWithEFCoreApp.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DbOperationsWithEFCoreApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {//creating object of AppDbContext class uning Dependancy Injection
        private readonly AppDbContext _appDbContext;

        public CurrencyController(AppDbContext appDbContext) {
            _appDbContext = appDbContext;
        }
        //create Action Method
        [HttpGet("")]
        public IActionResult GetallCurrencies()
        {// To call Database by Using Entity Framework
            var result=_appDbContext.Currencies.ToList();
            return Ok(result);
        }
    }
}

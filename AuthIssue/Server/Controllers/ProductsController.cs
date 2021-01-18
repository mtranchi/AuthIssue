using AuthIssue.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthIssue.Server.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        string[] names = { "Hello", "Dolly", "How 'boutcha" };
        //wtf over
        private readonly ILogger<ProductsController> _logger;

        public ProductsController(ILogger<ProductsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            Product[] products = new Product[names.Length];

            for (int i = 0; i < names.Length; i++)
            {
                products[i] = new Product { Name = names[i] };
            }

            return products;
        }
    }
}

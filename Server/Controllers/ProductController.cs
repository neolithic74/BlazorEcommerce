﻿using BlazorEcommerce.Server.Data;
using BlazorEcommerce.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorEcommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly DataContext datacontext;

        public ProductController(DataContext datacontext)
        {
            this.datacontext = datacontext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProduct()
        {
            try
            {
                var products = await datacontext.Products.ToListAsync();
                return Ok(products);
            }
            catch (Exception)
            {
                throw;
            }
            
        }
    }
}

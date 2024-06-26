﻿using Microsoft.AspNetCore.Mvc;
using MyGrapghQLSample.Services;

namespace MyGrapghQLSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        #region constructor
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        #endregion


        [HttpGet(Name = "GetAllProducts")]
        public IActionResult Get() =>
             Ok(_productService.GetProducts());
    }
}

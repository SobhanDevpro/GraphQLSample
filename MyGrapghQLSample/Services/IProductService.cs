﻿using MyGrapghQLSample.Models;

namespace MyGrapghQLSample.Services
{
    public interface IProductService
    {
        List<Product> GetProducts();
        Product GetProductById(int id);
    }
}

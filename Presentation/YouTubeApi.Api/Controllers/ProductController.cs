﻿using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YouTubeApi.Application.Features.Products.Queries.GetAllProducts;

namespace YouTubeApi.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator mediator;
        public ProductController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var response = mediator.Send(new GetAllProductsQueryRequest());

            return Ok(response);
        }
    }
}

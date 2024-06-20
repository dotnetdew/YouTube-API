using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouTubeApi.Application.Interfaces.UnitOfWorks;
using YouTubeApi.Domain.Entities;

namespace YouTubeApi.Application.Features.Products.Queries.GetAllProducts;

public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQueryRequest, IList<GetAllProductsQueryResponse>>
{
    private readonly IUnitOfWork unitOfWork;

    public GetAllProductsQueryHandler(IUnitOfWork unitOfWork)
    {
        this.unitOfWork = unitOfWork;
    }

    public async Task<IList<GetAllProductsQueryResponse>> Handle(GetAllProductsQueryRequest request, CancellationToken cancellationToken)
    {
        var products = await unitOfWork.GetReadRepository<Product>().GetAllAsync();

        List<GetAllProductsQueryResponse> response = new();

        foreach (var product in products)
        {
            response.Add(new GetAllProductsQueryResponse
            {
                Title = product.Title,
                Discount = product.Discount,
                Description = product.Description,
                Price = product.Price - (product.Price * product.Discount * 100)
            });
        }

        return response;
    }
}

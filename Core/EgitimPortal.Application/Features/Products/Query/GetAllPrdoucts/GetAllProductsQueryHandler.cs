using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgitimPortal.Application.Interfaces.UnitOfWorks;
using EgitimPortal.Domain.Entities;
using EgitimPortal.Application.Interfaces.AutoMapper;

namespace EgitimPortal.Application.Features.Products.Query.GetAllPrdoucts
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQueryRequest, IList<GetAllProductsQueryResponse>>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

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
                    title = product.title,
                    description = product.description,
                    price = product.price,
                });
            }

            return response;

            
            


        }
    }
}

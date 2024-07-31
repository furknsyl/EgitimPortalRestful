using EgitimPortal.Application.Features.Products.Query.GetAllCategory;
using EgitimPortal.Application.Interfaces.AutoMapper;
using EgitimPortal.Application.Interfaces.UnitOfWorks;
using EgitimPortal.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

public class GetAllCategoryQueryHandler : IRequestHandler<GetAllCategoryQueryRequest, IList<GetAllCategoryQueryResponse>>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public GetAllCategoryQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }

    public async Task<IList<GetAllCategoryQueryResponse>> Handle(GetAllCategoryQueryRequest request, CancellationToken cancellationToken)
    {
        var products = await unitOfWork.GetReadRepository<Category>().GetAllAsync();

        var response = new List<GetAllCategoryQueryResponse>();
        foreach (var product in products)
        {
            response.Add(new GetAllCategoryQueryResponse
            {
                Title = product.Name,
                // Gerekirse diğer özellikleri eşleyin
            });
        }
        
        return response;
    }
}
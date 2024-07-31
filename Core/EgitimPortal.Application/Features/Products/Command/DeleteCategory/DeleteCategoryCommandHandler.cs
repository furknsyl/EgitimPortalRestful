using EgitimPortal.Application.Bases;
using EgitimPortal.Application.Features.Products.Command.DeleteCategory;
using EgitimPortal.Application.Interfaces.AutoMapper;
using EgitimPortal.Application.Interfaces.UnitOfWorks;
using EgitimPortal.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using System.Threading;
using System.Threading.Tasks;

namespace EgitimPortal.Application.Features.Categories.Command.DeleteCategory
{
    public class DeleteCategoryCommandHandler : BaseHandler, IRequestHandler<DeleteCategoryCommandRequest, Unit>
    {
        public DeleteCategoryCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor)
            : base(mapper, unitOfWork, httpContextAccessor)
        {
        }

        public async Task<Unit> Handle(DeleteCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            var category = await unitOfWork.GetReadRepository<Category>().GetByIdAsync(request.Id);

            if (category == null)
            {
                throw new Exception("Category not found.");
            }

            unitOfWork.GetWriteRepository<Category>().Delete(category);
            await unitOfWork.SaveAsync();

            return Unit.Value;
        }
    }
}
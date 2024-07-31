using EgitimPortal.Application.Bases;
using EgitimPortal.Application.Features.Products.Command.UpdateCategory;
using EgitimPortal.Application.Interfaces.AutoMapper;
using EgitimPortal.Application.Interfaces.UnitOfWorks;
using EgitimPortal.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using System.Threading;
using System.Threading.Tasks;

namespace EgitimPortal.Application.Features.Categories.Command.UpdateCategory
{
    public class UpdateCategoryCommandHandler : BaseHandler, IRequestHandler<UpdateCategoryCommandRequest, Unit>
    {
        public UpdateCategoryCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor)
            : base(mapper, unitOfWork, httpContextAccessor)
        {
        }

        public async Task<Unit> Handle(UpdateCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            var category = await unitOfWork.GetReadRepository<Category>().GetByIdAsync(request.Id);

            if (category == null)
            {
                throw new Exception("Category not found.");
            }

            category.Name = request.Name;
            // Diğer güncellenecek alanlar

            unitOfWork.GetWriteRepository<Category>().Update(category);
            await unitOfWork.SaveAsync();

            return Unit.Value;
        }
    }
}
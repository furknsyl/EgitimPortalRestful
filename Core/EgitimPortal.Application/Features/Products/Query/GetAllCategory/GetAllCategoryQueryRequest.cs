using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimPortal.Application.Features.Products.Query.GetAllCategory
{
    public class GetAllCategoryQueryRequest:IRequest<IList<GetAllCategoryQueryResponse>>
    {
    }
}

using EgitimPortal.Application.Interfaces.Repositories;
using EgitimPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimPortal.Persistance.Repositories
{
    public interface ICategoryRepository : IWriteRepository<Category>, IReadRepository<Category>
    {
    }
}

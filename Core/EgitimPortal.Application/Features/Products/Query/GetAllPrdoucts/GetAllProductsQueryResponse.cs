using Bogus.DataSets;
using EgitimPortal.Application.Interfaces.UnitOfWorks;
using EgitimPortal.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimPortal.Application.Features.Products.Query.GetAllPrdoucts
{
    public class GetAllProductsQueryResponse
    {
        public string title { get; set; }

        public string description { get; set; }

        public decimal price { get; set; }
    }
}

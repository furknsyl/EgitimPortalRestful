﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimPortal.Application.Features.Products.Command.UpdateProduct
{
    public class UpdateProductCommandRequest:IRequest<Unit>
    {
        public int Id {  get; set; }    
        public string title { get; set; }

        public string description { get; set; }

        public decimal price { get; set; }

        public IList<int> CategoryIds { get; set; }
    }
}

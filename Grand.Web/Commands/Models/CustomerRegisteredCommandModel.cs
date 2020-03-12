﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grand.Core.Domain.Customers;
using Grand.Core.Domain.Stores;
using Grand.Web.Models.Customer;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace Grand.Web.Commands.Models
{
    public class CustomerRegisteredCommandModel : IRequest<bool>
    {
        public Customer Customer { get; set; }
        public Store Store { get; set; }
        public RegisterModel Model { get; set; }
        public IFormCollection Form { get; set; }
        public string CustomerAttributesXml { get; set; }
    }
}
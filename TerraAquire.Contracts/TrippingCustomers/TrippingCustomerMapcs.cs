using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerraAquire.Contracts.HouseModels;
using TerraAquire.Data;

namespace TerraAquire.Contracts.TrippingCustomers
{

    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<TrippingCustomer, TrippingCustomerDto>();
            CreateMap<TrippingCustomerDto, TrippingCustomer>();
        }
    }
}


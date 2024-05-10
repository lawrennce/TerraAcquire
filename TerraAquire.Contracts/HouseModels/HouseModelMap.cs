using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerraAquire.Data;

namespace TerraAquire.Contracts.HouseModels
{
 
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<HouseModel,HouseModelDto>();
            CreateMap<HouseModelDto, HouseModel>();
        }
    }
}

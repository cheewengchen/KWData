using AutoMapper;
using KWData.Data;
using KWData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KWData.Mappings
{
    public class Maps : Profile
    {
        public Maps() 
        {
            CreateMap<Customer, CustomerVM>().ReverseMap();
        }        
    }
}

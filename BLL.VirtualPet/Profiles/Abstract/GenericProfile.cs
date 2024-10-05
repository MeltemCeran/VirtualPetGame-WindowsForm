using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.VirtualPet.Profiles.Abstract
{
    public abstract class GenericProfile<TEntity,TModel> : Profile
    {
        protected GenericProfile() 
        {
            CreateMap<TEntity,TModel>().ReverseMap();        
        }
    }
}

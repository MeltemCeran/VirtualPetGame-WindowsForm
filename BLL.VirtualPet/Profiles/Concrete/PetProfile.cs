using BLL.VirtualPet.Models;
using BLL.VirtualPet.Profiles.Abstract;
using DAL.VirtualPet.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.VirtualPet.Profiles.Concrete
{
    public class PetProfile : GenericProfile<Pet,PetModel>
    {
    }
}

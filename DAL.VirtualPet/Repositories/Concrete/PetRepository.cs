using DAL.VirtualPet.Context;
using DAL.VirtualPet.Entities.Concrete;
using DAL.VirtualPet.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.VirtualPet.Repositories.Concrete
{
    public class PetRepository : Repository<Pet>
    {
        public PetRepository(VirtualPetDbContext context) : base(context)
        {
        }
    }
}

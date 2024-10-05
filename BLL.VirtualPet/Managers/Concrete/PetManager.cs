using AutoMapper;
using BLL.VirtualPet.Managers.Abstract;
using BLL.VirtualPet.Models;
using DAL.VirtualPet.Context;
using DAL.VirtualPet.Entities.Concrete;
using DAL.VirtualPet.Repositories.Abstract;
using DAL.VirtualPet.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.VirtualPet.Managers.Concrete
{
    public class PetManager : Manager<PetModel, Pet>
    {
        public PetManager()
        {
            _repository = new PetRepository(new VirtualPetDbContext());
        }
    }
}

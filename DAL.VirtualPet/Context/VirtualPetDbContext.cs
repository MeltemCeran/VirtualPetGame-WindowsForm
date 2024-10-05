using DAL.VirtualPet.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.VirtualPet.Context
{
    public class VirtualPetDbContext : DbContext
    {
        public DbSet<Pet> Pets { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-3HH2461E;Database=VirtualPetDb;Trusted_Connection=true;Trustservercertificate=true");
        }
    }
}

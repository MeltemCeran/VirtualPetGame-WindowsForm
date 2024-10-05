using DAL.VirtualPet.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.VirtualPet.Entities.Concrete
{
    public class Pet : BaseEntity
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int? Happiness { get; set; }
        public int? Hunger { get; set; }
        public int? Energy { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.VirtualPet.Models
{
    public class PetModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Happiness { get; set; }
        public int Hunger { get; set; }
        public int Energy { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.VirtualPet.Managers.Abstract
{
    public interface IManager<TModel> where TModel : class
    {
        public void Add(TModel model);
        public void Update(TModel model);
        public void Delete(TModel model);
        public void Delete(int id);
        public ICollection<TModel> GetAll();
        public TModel GetById(int id);
    }
}

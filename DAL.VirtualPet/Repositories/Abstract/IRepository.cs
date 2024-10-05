using DAL.VirtualPet.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.VirtualPet.Repositories.Abstract
{
    public interface IRepository<TEntity> 
    {
        public void Add(TEntity entity);
        public void Update(TEntity entity);
        public void Delete(TEntity entity);
        public void Delete(int id);
        public IQueryable<TEntity> GetAll();
        public TEntity GetById(int id);
    }
}

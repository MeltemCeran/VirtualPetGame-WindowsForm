using AutoMapper;
using DAL.VirtualPet.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.VirtualPet.Managers.Abstract
{
    public abstract class Manager<TModel, TEntity> : IManager<TModel> where TModel : class
    {
        protected IRepository<TEntity> _repository;
        protected IMapper _mapper;
        protected MapperConfiguration _config;

        protected Manager()
        {
            _config = new MapperConfiguration(cfg =>
            cfg.CreateMap<TModel, TEntity>().ReverseMap());

            _mapper = new Mapper(_config);
        }

        public ICollection<TModel> GetAll()
        {
            var entities = _repository.GetAll();
            return _mapper.Map<ICollection<TModel>>(entities);
        }

        public TModel GetById(int id)
        {
            var entity = _repository.GetById(id);
            return _mapper.Map<TModel>(entity);
        }

        public void Add(TModel model) //Chatgpt bunlara virtual demiş neden?
        {
            var entity = _mapper.Map<TEntity>(model);
            _repository.Add(entity);
        }

        public void Update(TModel model)
        {
            var entity = _mapper.Map<TEntity>(model);
            _repository.Update(entity);
        }

        public void Delete(TModel model)
        {
            var entity = _mapper.Map<TEntity>(model);
            _repository.Delete(entity);
        }

        public void Delete(int id)
        {
            _repository.Delete(id); //Buradan hiç emin değilim.
        }

        

       
    }
}

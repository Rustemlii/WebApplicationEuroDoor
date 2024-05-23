using AutoMapper;
using Business.Abstract;
using DataAccess.AppContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BaseService<RqDTO, TEntity, RsDTO> 
        : IBaseService<RqDTO, TEntity, RsDTO> where TEntity : class
    {
        protected readonly AppDbContext _dbContext;
        protected readonly DbSet<TEntity> _dbSet;
        protected readonly IMapper _mapper;

        public BaseService(AppDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _dbSet = _dbContext.Set<TEntity>();
        }

        public void Delete(int id)
        {
            var value = _dbSet.Find(id);
            _dbSet.Remove(value);
            _dbContext.SaveChanges();
        }

        public IEnumerable<RsDTO> GetAll()
        {
            var values = _dbSet.ToList();
            var rsdto = _mapper.Map<IEnumerable<RsDTO>>(values);
            return rsdto;
        }

        public RsDTO GetById(int id)
        {
            var value = _dbSet.Find(id);
            var rsdto = _mapper.Map<RsDTO>(value);
            return rsdto;
        }

        public RsDTO Insert(RqDTO dto)
        {
            var value = _mapper.Map<TEntity>(dto);
            _dbContext.Add(value);
            _dbContext.SaveChanges();

            var rsdto = _mapper.Map<RsDTO>(value);
            return rsdto;
        }

        public void Update(RqDTO dto)
        {
            var value = _mapper.Map<TEntity>(dto);
            _dbContext.Update(value);
            _dbContext.SaveChanges();
        }
    }
}

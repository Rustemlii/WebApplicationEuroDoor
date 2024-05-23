using AutoMapper;
using Business.Abstract;
using DataAccess.AppContext;
using DataAccess.Entity;
using DTO.EntityDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	public class OrderDetailService : BaseService<OrderDetailDTO, OrderDetail, OrderDetailDTO>, IOrderDetailService
	{
		public OrderDetailService(AppDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
		{
		}

        public IEnumerable<OrderDetailDTO> IncludeGetById(int id)
        {
            var values = _dbSet.Where(x=>x.OrderId==id).ToList();
            var bringDto=_mapper.Map<IEnumerable<OrderDetailDTO>>(values);
            return bringDto;
        }
    }
}

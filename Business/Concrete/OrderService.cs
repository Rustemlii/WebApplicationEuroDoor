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
	public class OrderService : BaseService<OrderDTO, Order, OrderDTO>, IOrderService
	{
		public OrderService(AppDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
		{
		}
	}
}

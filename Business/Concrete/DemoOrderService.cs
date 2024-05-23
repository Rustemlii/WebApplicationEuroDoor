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
	public class DemoOrderService : BaseService<DemoOrderDTO, DemoOrder, DemoOrderDTO>, IDemoOrderService
	{
		public DemoOrderService(AppDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
		{
		}
	}
}

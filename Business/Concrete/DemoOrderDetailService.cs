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
	public class DemoOrderDetailService : BaseService<DemoOrderDetailDTO, DemoOrderDetail, DemoOrderDetailDTO>, IDemoOrderDetailService
	{
		public DemoOrderDetailService(AppDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
		{
		}

        public IEnumerable<DemoOrderDetailDTO> IncludeGetById(int id)
        {
            var values=_dbSet.Where(x=>x.DemoOrderId == id).ToList();
            var BringDto=_mapper.Map<IEnumerable<DemoOrderDetailDTO>>(values);
            return BringDto;
        }
    }
}

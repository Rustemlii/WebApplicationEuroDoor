using DataAccess.Entity;
using DTO.EntityDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
	public interface IDemoOrderService:IBaseService<DemoOrderDTO,DemoOrder,DemoOrderDTO>
	{
	}
}

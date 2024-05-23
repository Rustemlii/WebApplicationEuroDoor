using AutoMapper;
using Business.Abstract;
using DataAccess.AppContext;
using DataAccess.Entity;
using DTO.EntityDTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserService
        : BaseService<UserDTO, User, UserDTO>, IUserService
    {
        public UserService(AppDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

		public IEnumerable<UserDTO> GetAllInclude()
		{
			var values = _dbSet.Include(r=>r.Role).ToList();
            var rsdto = _mapper.Map<IEnumerable<UserDTO>>(values);
            return rsdto;
		}
	}
}

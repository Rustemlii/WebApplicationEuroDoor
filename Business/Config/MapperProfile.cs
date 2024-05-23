using AutoMapper;
using DataAccess.Entity;
using DTO.EntityDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Config
{
    public class MapperProfile : Profile
    {
        public MapperProfile() 
        {
            CreateMap<DetallarDTO, Detallar>();
            CreateMap<Detallar, DetallarDTO>();

            CreateMap<UserDTO, User>();
            CreateMap<User, UserDTO>();

            CreateMap<RoleDTO, Role>();
            CreateMap<Role, RoleDTO>();

            CreateMap<OrderDTO,Order>();
            CreateMap<Order, OrderDTO>();

            CreateMap<OrderDetailDTO,OrderDetail>();
            CreateMap<OrderDetail, OrderDetailDTO>();

            CreateMap<DemoOrderDTO,DemoOrder>();
            CreateMap<DemoOrder, DemoOrderDTO>();

            CreateMap<DemoOrderDetailDTO,DemoOrderDetail>();
            CreateMap<DemoOrderDetail, DemoOrderDetailDTO>();

            CreateMap<DemoOrderDTO,OrderDTO>();
            CreateMap<OrderDTO, DemoOrderDTO>();

            CreateMap<DemoOrderDetailDTO,OrderDetailDTO>();
            CreateMap<OrderDetailDTO, DemoOrderDetailDTO>();
        }
    }
}

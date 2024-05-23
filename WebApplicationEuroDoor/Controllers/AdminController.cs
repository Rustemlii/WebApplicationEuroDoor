using AutoMapper;
using Business.Abstract;
using DataAccess.AppContext;
using DataAccess.Entity;
using DTO.EntityDTO;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Claims;

namespace WebApplicationEuroDoor.Controllers
{
    public class AdminController : Controller
    {
        private readonly IDetallarService _detallar;
        private readonly IUserService _user;
        private readonly AppDbContext _dbContext;
        private readonly IRoleService _roleService;
        private readonly IOrderService _orderService;
        private readonly IOrderDetailService _orderDetailService;
        private readonly IDemoOrderService _demoOrderService;
        private readonly IDemoOrderDetailService _demoOrderDetailService;
        private readonly IMapper _mapper;

        public AdminController(IMapper mapper, IDetallarService detallar, IUserService user, AppDbContext dbContext, IRoleService roleService, IOrderService orderService, IOrderDetailService orderDetailService, IDemoOrderService demoOrderService, IDemoOrderDetailService demoOrderDetailService)
        {
            _detallar = detallar;
            _user = user;
            _dbContext = dbContext;
            _roleService = roleService;
            _orderService = orderService;
            _orderDetailService = orderDetailService;
            _demoOrderService = demoOrderService;
            _demoOrderDetailService = demoOrderDetailService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        #region Product

        public IActionResult Product()
        {
            var values = _detallar.GetAll();
            return View(values);
        }
        public IActionResult ProductAdd()
        {

            return View();
        }
        [HttpPost]
        public IActionResult ProductAdd(DetallarDTO dto)
        {
            _detallar.Insert(dto);
            return RedirectToAction("Product");
        }
        public IActionResult ProductDelete(int id)
        {
            _detallar.Delete(id);
            return RedirectToAction("Product");
        }
        [HttpGet]
        public IActionResult ProductUpdate(int id)
        {
            var values = _detallar.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult ProductUpdate(DetallarDTO dto)
        {
            _detallar.Update(dto);
            return RedirectToAction("Product");
        }


        #endregion


        #region Register

        public IActionResult UserControl()
        {
            var value = _user.GetAllInclude();
            return View(value);
        }



        [HttpGet]
        public IActionResult Register()
        {
            IEnumerable<SelectListItem> valueGet = (from x in _roleService.GetAll()
                                                    select new SelectListItem
                                                    {
                                                        Text = x.Name,
                                                        Value = x.Id.ToString()
                                                    }).ToList();
            ViewBag.c = valueGet;
            return View();
        }

        [HttpPost]
        public IActionResult Register(UserDTO dto)
        {
            IEnumerable<SelectListItem> valueGet = (from x in _roleService.GetAll()
                                                    select new SelectListItem
                                                    {
                                                        Text = x.Name,
                                                        Value = x.Id.ToString()
                                                    }).ToList();
            ViewBag.c = valueGet;

            var values = _user.Insert(dto);
            _dbContext.SaveChanges();
            return RedirectToAction("UserControl");
        }
        [HttpGet]
        public IActionResult UserUpdate(int id)
        {
            IEnumerable<SelectListItem> valueGet = (from x in _roleService.GetAll()
                                                    select new SelectListItem
                                                    {
                                                        Text = x.Name,
                                                        Value = x.Id.ToString()
                                                    }).ToList();
            ViewBag.c = valueGet;

            var value = _user.GetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UserUpdate(UserDTO dto)
        {
            IEnumerable<SelectListItem> valueGet = (from x in _roleService.GetAll()
                                                    select new SelectListItem
                                                    {
                                                        Text = x.Name,
                                                        Value = x.Id.ToString()
                                                    }).ToList();
            ViewBag.c = valueGet;
            _user.Update(dto);
            return RedirectToAction("UserControl");
        }
        public IActionResult UserDelete(int id)
        {
            _user.Delete(id);
            return RedirectToAction("UserControl");
        }

        #endregion


        #region Orders
        [HttpGet]
        public IActionResult Order()
        {
            ViewBag.demo = _demoOrderService.GetAll();
            var values = _orderService.GetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult OrderAdd(int id)
        {
            ViewBag.demo1 = _demoOrderService.GetById(id);
            return View();
        }
        int? x;

        [HttpPost]
        public IActionResult OrderAdd(OrderDTO dto)
        {
            dto.Id = 0;
            _orderService.Insert(dto);
            var bringOrder = _orderService.GetAll().Max(x=>x.Id);
            var values = _demoOrderDetailService.GetAll();

            OrderDetail bring = new OrderDetail();
            foreach (var item in values)
            {
                bring.Id = 0;
                bring.Name = item.Name;
                bring.Width = item.Width;
                bring.Height = item.Height;
                bring.SalePrice = item.SalePrice;
                bring.Quantity = item.Quantity;
                bring.Color = item.Color;
                bring.OrderId = bringOrder;

                _dbContext.Add(bring);
                _dbContext.SaveChanges();

                x = bring.OrderId;
            }



            return RedirectToAction("OrderDetail",new {Id=x});
        }


        public IActionResult OrderDetail(int id)
        {

            var values = _orderDetailService.IncludeGetById(id);
            ViewBag.order = values;

            return View();
        }


        #endregion

    }
}

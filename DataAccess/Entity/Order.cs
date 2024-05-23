using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
	public class Order
	{
        public int Id { get; set; }
        public string? Name { get; set; }
		[Range(0, int.MaxValue)]
		[Column(TypeName = "decimal(10,2)")]
		public decimal? Price { get; set; }
        public string? Saler { get; set; }
        public string? Customer { get; set; }
        public List<OrderDetail>?OrderDetails { get; set; }
    }
}

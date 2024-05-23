using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
	public class OrderDetail
	{
        public int Id { get; set; }
		public string? Limer { get; set; }
		public string? Name { get; set; }
		public string? Color { get; set; }
		public int? Quantity { get; set; }

		[Range(0, int.MaxValue)]
		[Column(TypeName = "decimal(10,2)")]
		public decimal? Width { get; set; }

		[Range(0, int.MaxValue)]
		[Column(TypeName = "decimal(10,2)")]
		public decimal? Height { get; set; }

		[Range(0, int.MaxValue)]
		[Column(TypeName = "decimal(10,2)")]
		public decimal? SalePrice { get; set; }
        public int? OrderId { get; set; }
        public Order? Order { get; set; }

    }
}

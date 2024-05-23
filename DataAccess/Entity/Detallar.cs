using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Detallar
    {
        public int Id { get; set; }

        public string? Limer { get; set; }
        public string? Name { get; set; }
        public string? Color { get; set; }
        public int Quantity { get; set; }

        [Range(0, int.MaxValue)]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Width { get; set; }

        [Range(0, int.MaxValue)]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Height { get; set; }

        [Range(0, int.MaxValue)]
        [Column(TypeName = "decimal(10,2)")]
        public decimal GetPrice { get; set;}

        [Range(0, int.MaxValue)]
        [Column(TypeName = "decimal(10,1)")]
        public decimal SalePrice { get; set; }
        public string? ImageURL { get; set; }
		[Range(0, int.MaxValue)]
		[Column(TypeName = "decimal(10,1)")]

		///////////////////////////////////////////
		public decimal Etek { get; set; }
		[Range(0, int.MaxValue)]
		[Column(TypeName = "decimal(10,1)")]
		public decimal EtekRezini { get; set; }
		[Range(0, int.MaxValue)]
		[Column(TypeName = "decimal(10,1)")]
		public decimal Tuk { get; set; }
		[Range(0, int.MaxValue)]
		[Column(TypeName = "decimal(10,1)")]
		public decimal Mator { get; set; }
		[Range(0, int.MaxValue)]
		[Column(TypeName = "decimal(10,1)")]
		public decimal MatorunQisaQolu { get; set; }
		[Range(0, int.MaxValue)]
		[Column(TypeName = "decimal(10,1)")]
		public decimal MatorunUzunQolu { get; set; }
		[Range(0, int.MaxValue)]
		[Column(TypeName = "decimal(10,1)")]
		public decimal YanDirekler { get; set; }
		[Range(0, int.MaxValue)]
		[Column(TypeName = "decimal(10,1)")]
		public decimal Boru { get; set; }
		[Range(0, int.MaxValue)]
		[Column(TypeName = "decimal(10,1)")]
		public decimal Qutu { get; set; }
		[Range(0, int.MaxValue)]
		[Column(TypeName = "decimal(10,1)")]
		public decimal Asqi { get; set; }
		[Range(0, int.MaxValue)]
		[Column(TypeName = "decimal(10,1)")]
		public decimal BoruQapagi { get; set; }
		[Range(0, int.MaxValue)]
		[Column(TypeName = "decimal(10,1)")]
		public decimal Pult { get; set; }
		[Range(0, int.MaxValue)]
		[Column(TypeName = "decimal(10,1)")]
		public decimal Rolik { get; set; }
		[Range(0, int.MaxValue)]
		[Column(TypeName = "decimal(10,1)")]
		public decimal Tapa { get; set; }


    }
}

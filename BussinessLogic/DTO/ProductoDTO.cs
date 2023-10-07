using System;
using DataAccess.Entities;

namespace BussinessLogic.DTO
{
	public class ProductoDTO
	{
        public int IdProducto { get; set; }

        public string? Descripcion { get; set; }

        public int? idCategoria { get; set; }

    }
}


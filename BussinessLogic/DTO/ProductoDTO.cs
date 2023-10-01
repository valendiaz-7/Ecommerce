using System;
using DataAccess.Entities;

namespace BussinessLogic.DTO
{
	public class ProductoDTO
	{
        public int Id { get; set; }

        public string? Descripcion { get; set; }

        public int? idCategoria { get; set; }

    }
}


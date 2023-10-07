﻿using System;
using DataAccess.Entities;

namespace BussinessLogic.DTO
{
    public class PublicacionDTO
    {
    public int IdPublicacion { get; set; }


    public float? Precio { get; set; }

    public int Stock { get; set; }

    public virtual Producto IdProductoNavigation { get; set; } = null!;

    }
}

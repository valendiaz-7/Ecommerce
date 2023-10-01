using System;
using System.Collections.Generic;

namespace DataAccess.Entities;

public partial class Categoria
{
    public int IdCategoria { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Producto> Producto { get; set; } = new List<Producto>();
}

using System;
using System.Collections.Generic;

namespace DataAccess.Entities;

public partial class Producto
{
    public int IdProducto { get; set; }

    public string? Descripcion { get; set; }

    public int idCategoria { get; set; }

    public virtual Categoria idCategoriaNavigation { get; set; } = null!;

    public virtual ICollection<Publicacion> Publicacion { get; set; } = new List<Publicacion>();
}

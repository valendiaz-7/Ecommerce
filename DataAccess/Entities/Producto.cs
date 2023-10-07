using System;
using System.Collections.Generic;

namespace DataAccess.Entities;

public partial class Producto
{
    public int IdProducto { get; set; }

    public string? Descripcion { get; set; }

    public int IdCategoria { get; set; }

    public DateTime FechaAlta { get; set; }

    public DateTime? FechaBaja { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public virtual Categoria IdCategoriaNavigation { get; set; } = null!;

    public virtual ICollection<Publicacion> Publicacion { get; set; } = new List<Publicacion>();
}

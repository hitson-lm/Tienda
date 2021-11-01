using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Models
{
    public partial class ProductoImagen
    {
        public int ProductoImagenId { get; set; }
        public int ProductoId { get; set; }
        public string Imagen { get; set; }
        public string Titulo { get; set; }

        public virtual Producto Producto { get; set; }
    }
}

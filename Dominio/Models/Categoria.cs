using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Models
{
    public partial class Categoria
    {
        public Categoria()
        {
            Producto = new HashSet<Producto>();
        }

        public int Id { get; set; }
        public string Denominacion { get; set; }

        public virtual ICollection<Producto> Producto { get; set; }
    }
}

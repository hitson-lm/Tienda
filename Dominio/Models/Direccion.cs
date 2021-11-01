using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Models
{
    public partial class Direccion
    {
        public Direccion()
        {
            Pedido = new HashSet<Pedido>();
        }

        public int Id { get; set; }
        public string Denominacion { get; set; }
        public string Estado { get; set; }
        public int? ClienteId { get; set; }

        public virtual ICollection<Pedido> Pedido { get; set; }
    }
}

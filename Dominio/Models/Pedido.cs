using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Models
{
    public partial class Pedido
    {
        public Pedido()
        {
            PedidoDetalle = new HashSet<PedidoDetalle>();
        }

        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int? DireccionId { get; set; }
        public DateTime Fecha { get; set; }
        public decimal? Total { get; set; }
        public string Estado { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Direccion Direccion { get; set; }
        public virtual ICollection<PedidoDetalle> PedidoDetalle { get; set; }
    }
}

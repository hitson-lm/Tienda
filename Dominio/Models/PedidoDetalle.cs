using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Models
{
    public partial class PedidoDetalle
    {
        public int Id { get; set; }
        public int PedidoId { get; set; }
        public int ProductoId { get; set; }
        public decimal? Precio { get; set; }
        public int Cantidad { get; set; }

        public virtual Pedido Pedido { get; set; }
        public virtual Producto Producto { get; set; }
    }
}

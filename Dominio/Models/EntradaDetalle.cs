using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Models
{
    public partial class EntradaDetalle
    {
        public int Id { get; set; }
        public int EntradaId { get; set; }
        public int ProductoId { get; set; }
        public decimal? Costo { get; set; }
        public int Cantidad { get; set; }
        public string Lote { get; set; }
        public DateTime? FechaVencimiento { get; set; }

        public virtual Entrada Entrada { get; set; }
        public virtual Producto Producto { get; set; }
    }
}

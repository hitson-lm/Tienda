using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Models
{
    public partial class Entrada
    {
        public Entrada()
        {
            EntradaDetalle = new HashSet<EntradaDetalle>();
        }

        public int Id { get; set; }
        public int ProveedorId { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public DateTime Fecha { get; set; }
        public decimal? Total { get; set; }
        public string Estado { get; set; }
        public int UsuarioCreacionId { get; set; }
        public DateTime FechaCreacion { get; set; }

        public virtual Proveedor Proveedor { get; set; }
        public virtual Usuario UsuarioCreacion { get; set; }
        public virtual ICollection<EntradaDetalle> EntradaDetalle { get; set; }
    }
}

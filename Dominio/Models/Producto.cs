using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Models
{
    public partial class Producto
    {
        public Producto()
        {
            EntradaDetalle = new HashSet<EntradaDetalle>();
            PedidoDetalle = new HashSet<PedidoDetalle>();
            ProductoImagen = new HashSet<ProductoImagen>();
        }

        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Denominacion { get; set; }
        public string Descripcion { get; set; }
        public decimal Costo { get; set; }
        public decimal Precio { get; set; }
        public int Existencias { get; set; }
        public int MarcaId { get; set; }
        public int CategoriaId { get; set; }
        public string Estado { get; set; }

        public virtual Categoria Categoria { get; set; }
        public virtual Marca Marca { get; set; }
        public virtual ICollection<EntradaDetalle> EntradaDetalle { get; set; }
        public virtual ICollection<PedidoDetalle> PedidoDetalle { get; set; }
        public virtual ICollection<ProductoImagen> ProductoImagen { get; set; }
    }
}

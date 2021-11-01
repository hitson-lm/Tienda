using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Models
{
    public partial class Proveedor
    {
        public Proveedor()
        {
            Entrada = new HashSet<Entrada>();
        }

        public int Id { get; set; }
        public string Nombres { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string Correo { get; set; }
        public string Celular { get; set; }

        public virtual ICollection<Entrada> Entrada { get; set; }
    }
}

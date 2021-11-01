using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            Pedido = new HashSet<Pedido>();
        }

        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public string Celular { get; set; }

        public virtual ICollection<Pedido> Pedido { get; set; }
    }
}

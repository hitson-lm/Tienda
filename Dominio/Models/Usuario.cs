using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Entrada = new HashSet<Entrada>();
            UsuarioMenu = new HashSet<UsuarioMenu>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public string Celular { get; set; }
        public bool? Activo { get; set; }
        public bool? IndCambio { get; set; }

        public virtual ICollection<Entrada> Entrada { get; set; }
        public virtual ICollection<UsuarioMenu> UsuarioMenu { get; set; }
    }
}

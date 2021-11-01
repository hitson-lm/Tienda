using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Models
{
    public partial class Menu
    {
        public Menu()
        {
            UsuarioMenu = new HashSet<UsuarioMenu>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Modulo { get; set; }
        public string Icono { get; set; }
        public bool IndPadre { get; set; }
        public int? Referencia { get; set; }

        public virtual ICollection<UsuarioMenu> UsuarioMenu { get; set; }
    }
}

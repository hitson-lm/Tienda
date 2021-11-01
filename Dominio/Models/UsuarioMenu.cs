using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Models
{
    public partial class UsuarioMenu
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int MenuId { get; set; }

        public virtual Menu Menu { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}

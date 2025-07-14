using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvUsuarioActividade
    {
        public string? TipoUsuario { get; set; }
        public string? Perfil { get; set; }
        public string Usuario { get; set; } = null!;
        public string Idusuario { get; set; } = null!;
        public string? NombreActividad { get; set; }
        public string? DescripcionActividad { get; set; }
    }
}

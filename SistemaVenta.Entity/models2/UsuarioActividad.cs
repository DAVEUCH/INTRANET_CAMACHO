using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsuarioActividad
    {
        public string Pkid { get; set; } = null!;
        public int Idusuario { get; set; }
        public string Idactividad { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Vperfile
    {
        public int Pkid { get; set; }
        public string Idusuario { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int? IdperfilUsuario { get; set; }
        public string TipoUsuario { get; set; } = null!;
        public bool Perfil { get; set; }
    }
}

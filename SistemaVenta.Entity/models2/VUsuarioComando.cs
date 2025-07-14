using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VUsuarioComando
    {
        public string Idcontenedor { get; set; } = null!;
        public int? Idusuario { get; set; }
        public string Nombre { get; set; } = null!;
        public string IdactividadAsociada { get; set; } = null!;
        public int? Clave { get; set; }
    }
}

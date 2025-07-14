using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvUsvEContenedor3Niv
    {
        public string IdcontenedorPadre { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int IdconfiguracionContenedor { get; set; }
        public int Nivel1 { get; set; }
        public int Nivel2 { get; set; }
        public int Orden { get; set; }
    }
}

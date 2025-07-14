using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EContenedorConfiguracionvistum
    {
        public string Id { get; set; } = null!;
        public string IdtipoReferenciado { get; set; } = null!;
        public string IdconfiguracionVista { get; set; } = null!;
    }
}

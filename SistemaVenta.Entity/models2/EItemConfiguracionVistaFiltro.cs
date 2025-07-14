using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EItemConfiguracionVistaFiltro
    {
        public string FiltrosUsuarioId { get; set; } = null!;
        public string IdconfiguracionVista { get; set; } = null!;
        public int FiltrosUsuarioIdusuario { get; set; }
        public string FiltrosUsuarioFiltro { get; set; } = null!;
    }
}

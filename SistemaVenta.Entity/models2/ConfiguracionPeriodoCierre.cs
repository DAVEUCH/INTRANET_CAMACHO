using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ConfiguracionPeriodoCierre
    {
        public int Pkid { get; set; }
        public string IdtipoEntidadCierre { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string RutaEntidadCierre { get; set; } = null!;
        public bool Activo { get; set; }

        public virtual Clasificador IdtipoEntidadCierreNavigation { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EDefinicionParametroSubActividad
    {
        public string IddefinicionSubActividad { get; set; } = null!;
        public string DefinicionesParametroSubActividadId { get; set; } = null!;
        public string DefinicionesParametroSubActividadNombre { get; set; } = null!;
        public string? DefinicionesParametroSubActividadParametroTipo { get; set; }
        public string DefinicionesParametroSubActividadIdparametroTipoEnsamblado { get; set; } = null!;
        public string DefinicionesParametroSubActividadIdparametroTipoTipo { get; set; } = null!;
        public string? DefinicionesParametroSubActividadIdparametroTipoDiscreto { get; set; }
        public bool DefinicionesParametroSubActividadObligatorio { get; set; }
        public bool DefinicionesParametroSubActividadColeccion { get; set; }
    }
}

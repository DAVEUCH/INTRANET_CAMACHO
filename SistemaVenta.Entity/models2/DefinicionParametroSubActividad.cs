using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class DefinicionParametroSubActividad
    {
        public string Pkid { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string? ParametroTipo { get; set; }
        public string IddefinicionSubActividad { get; set; } = null!;
        public string IdparametroTipoEnsamblado { get; set; } = null!;
        public string IdparametroTipoTipo { get; set; } = null!;
        public string? IdparametroTipoDiscreto { get; set; }
        public bool Obligatorio { get; set; }
        public bool Coleccion { get; set; }

        public virtual DefinicionSubActividad IddefinicionSubActividadNavigation { get; set; } = null!;
    }
}

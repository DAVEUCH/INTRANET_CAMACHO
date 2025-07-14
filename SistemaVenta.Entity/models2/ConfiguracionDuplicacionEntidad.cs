using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ConfiguracionDuplicacionEntidad
    {
        public ConfiguracionDuplicacionEntidad()
        {
            CondicionDuplicacionEntidads = new HashSet<CondicionDuplicacionEntidad>();
            ReglaDuplicacionEntidads = new HashSet<ReglaDuplicacionEntidad>();
        }

        public string Pkid { get; set; } = null!;
        public string IdtipoAsociado { get; set; } = null!;
        public string NombreOperacion { get; set; } = null!;
        public bool EjecutarOperacionEnOrigen { get; set; }
        public bool Activo { get; set; }

        public virtual ICollection<CondicionDuplicacionEntidad> CondicionDuplicacionEntidads { get; set; }
        public virtual ICollection<ReglaDuplicacionEntidad> ReglaDuplicacionEntidads { get; set; }
    }
}

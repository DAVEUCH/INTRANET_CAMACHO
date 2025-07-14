using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class DefinicionSubActividad
    {
        public DefinicionSubActividad()
        {
            DefinicionNavegacionSubActividads = new HashSet<DefinicionNavegacionSubActividad>();
            DefinicionParametroSubActividads = new HashSet<DefinicionParametroSubActividad>();
            SubActividads = new HashSet<SubActividad>();
        }

        public string Pkid { get; set; } = null!;
        public string Idensamblado { get; set; } = null!;
        public string? Clase { get; set; }
        public string Descripcion { get; set; } = null!;
        public string Especificacion { get; set; } = null!;

        public virtual ICollection<DefinicionNavegacionSubActividad> DefinicionNavegacionSubActividads { get; set; }
        public virtual ICollection<DefinicionParametroSubActividad> DefinicionParametroSubActividads { get; set; }
        public virtual ICollection<SubActividad> SubActividads { get; set; }
    }
}

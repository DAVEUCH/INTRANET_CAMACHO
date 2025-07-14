using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ActivoFijoMetodoDepreciacion
    {
        public ActivoFijoMetodoDepreciacion()
        {
            ActivoFijoActivoFijos = new HashSet<ActivoFijoActivoFijo>();
        }

        public int Pkid { get; set; }
        public string Descripcion { get; set; } = null!;
        public string NumeroDocumentoAutorizacion { get; set; } = null!;

        public virtual ICollection<ActivoFijoActivoFijo> ActivoFijoActivoFijos { get; set; }
    }
}

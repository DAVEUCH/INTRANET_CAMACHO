using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ESubActividadSiguiente
    {
        public string IdsubActividad { get; set; } = null!;
        public string SubActividadesSiguientesId { get; set; } = null!;
        public string SubActividadesSiguientesValorNavegacion { get; set; } = null!;
        public string SubActividadesSiguientesNombreSubActividadNavegacion { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ESubActividad
    {
        public string Idactividad { get; set; } = null!;
        public string SubActividadesId { get; set; } = null!;
        public string SubActividadesIddefinicionSubActividad { get; set; } = null!;
        public string SubActividadesNombre { get; set; } = null!;
        public string SubActividadesRutaEstado { get; set; } = null!;
    }
}

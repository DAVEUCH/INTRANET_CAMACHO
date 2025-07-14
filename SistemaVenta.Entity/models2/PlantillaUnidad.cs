using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class PlantillaUnidad
    {
        public int Pkid { get; set; }
        public string Descripcion { get; set; } = null!;
        public string Abreviacion { get; set; } = null!;
        public int Factor { get; set; }
        public string Codigo { get; set; } = null!;
    }
}

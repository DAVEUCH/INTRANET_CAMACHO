using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EPlantillaUnidad
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } = null!;
        public string Abreviacion { get; set; } = null!;
        public int Factor { get; set; }
        public string Codigo { get; set; } = null!;
    }
}

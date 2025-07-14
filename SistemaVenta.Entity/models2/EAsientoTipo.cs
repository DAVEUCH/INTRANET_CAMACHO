using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EAsientoTipo
    {
        public int AsientosTipoId { get; set; }
        public int IdcptoOperacion { get; set; }
        public int AsientosTipoIdlibroAuxiliar { get; set; }
        public string AsientosTipoGlosa { get; set; } = null!;
        public bool AsientosTipoResumirEnLibroDiario { get; set; }
    }
}

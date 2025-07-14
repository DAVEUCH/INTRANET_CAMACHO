using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ECargoAbonoTipoReferencium
    {
        public int ReferenciasId { get; set; }
        public int IdcargoAbonoTipo { get; set; }
        public string ReferenciasRutaReferencia { get; set; } = null!;
    }
}

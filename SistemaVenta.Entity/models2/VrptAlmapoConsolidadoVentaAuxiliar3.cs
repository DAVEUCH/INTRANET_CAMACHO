using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptAlmapoConsolidadoVentaAuxiliar3
    {
        public int IdconsolidadoCarga { get; set; }
        public decimal TotalMinoristaContado { get; set; }
        public decimal TotalMinoristaCredito { get; set; }
        public decimal TotalMayoristaContado { get; set; }
        public decimal TotalMayoristaCredito { get; set; }
        public decimal TotalOtrosContado { get; set; }
        public decimal TotalOtrosCredito { get; set; }
        public decimal Total { get; set; }
        public string Descripcion { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptAlmapoConsolidadoDevolucionesAuxiliar3
    {
        public int IdconsolidadoCarga { get; set; }
        public decimal TotalMinoristaContado { get; set; }
        public decimal TotalMinoristaCredito { get; set; }
        public decimal TotalMayoristaContado { get; set; }
        public decimal TotalMayoristaCredito { get; set; }
        public decimal TotalOtrosContado { get; set; }
        public decimal TotalOtrosCredito { get; set; }
    }
}

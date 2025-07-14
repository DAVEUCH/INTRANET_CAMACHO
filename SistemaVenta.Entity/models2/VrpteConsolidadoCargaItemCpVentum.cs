using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteConsolidadoCargaItemCpVentum
    {
        public string TipoDocumento { get; set; } = null!;
        public int ItemCpConsolidadoCargaId { get; set; }
        public int ItemCpConsolidadoId { get; set; }
        public int ItemCpId { get; set; }
        public bool ItemCpEntrega { get; set; }
        public DateTime ItemCpFechaAceptacion { get; set; }
        public DateTime ItemCpFechaEmision { get; set; }
        public string ItemCpNumero { get; set; } = null!;
        public bool ItemCpAnulado { get; set; }
        public bool ItemCpCredito { get; set; }
        public DateTime ItemCpFechaVencimiento { get; set; }
        public DateTime ItemCpFechaProgramacionPago { get; set; }
        public decimal ItemCpSaldo { get; set; }
        public decimal ItemCpTotal { get; set; }
        public string ItemCpTipoCobrarPagar { get; set; } = null!;
        public int ItemCpMovSaldo { get; set; }
        public string ItemCpTipoCodigo { get; set; } = null!;
        public int ItemCpPersonaId { get; set; }
        public string ItemCpPersonaCodigo { get; set; } = null!;
        public string ItemCpPersonaNombre { get; set; } = null!;
        public int ItemCpResponsableId { get; set; }
        public string ItemCpResponsableCodigo { get; set; } = null!;
        public string ItemCpResponsableNombre { get; set; } = null!;
    }
}

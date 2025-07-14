using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VInfoCpVentaPercepcionFreddy
    {
        public int ComprobantePkid { get; set; }
        public string ComprobanteNumCp { get; set; } = null!;
        public string ComprobantePersonaNombre { get; set; } = null!;
        public string? ComprobantePersonaDocIdentidad { get; set; }
        public DateTime ComprobanteFechaEmision { get; set; }
        public string ItemComprobanteTipoCp { get; set; } = null!;
        public string ItemComprobanteNumCp { get; set; } = null!;
        public DateTime ItemComprobanteFechaEmision { get; set; }
        public decimal ItemComprobanteRelacionadoTotal { get; set; }
        public decimal ItemComprobantePercepcionPorcentaje { get; set; }
        public decimal ItemComprobantePercepcionMonto { get; set; }
        public decimal? ItemComprobantePercepcionTotal { get; set; }
        public decimal ItemComprobantePercepcionTotalCobrado { get; set; }
        public decimal MontoPercepcion { get; set; }
        public decimal Total { get; set; }
        public decimal Saldo { get; set; }
    }
}

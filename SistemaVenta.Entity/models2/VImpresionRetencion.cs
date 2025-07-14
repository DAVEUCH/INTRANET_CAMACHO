using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VImpresionRetencion
    {
        public int ComprobanteId { get; set; }
        public string NumCp { get; set; } = null!;
        public DateTime FechaEmision { get; set; }
        public string CodigoOrigenDestino { get; set; } = null!;
        public string NombreOrigenDestino { get; set; } = null!;
        public string RucOrigenDestino { get; set; } = null!;
        public string DireccionOrigenDestino { get; set; } = null!;
        public bool Tercero { get; set; }
        public string ItemTipoCp { get; set; } = null!;
        public string ItemNumeroCp { get; set; } = null!;
        public DateTime ItemFechaEmision { get; set; }
        public decimal ItemMontoPago { get; set; }
        public string? MontoLetras { get; set; }
        public decimal ItemImporteRetenido { get; set; }
        public string CodigoTipoCp { get; set; } = null!;
        public decimal TotalRetenido { get; set; }
        public string? MontoLetras2 { get; set; }
    }
}

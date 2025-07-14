using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvVentasDetComprobantesProdObsequio
    {
        public string NombreSucursal { get; set; } = null!;
        public DateTime FechaEmision { get; set; }
        public string TipoComprobante { get; set; } = null!;
        public string NumeroComprobante { get; set; } = null!;
        public string? NroGuiaSalida { get; set; }
        public string Cliente { get; set; } = null!;
        public decimal? Cantidad { get; set; }
        public decimal? ValorUnitario { get; set; }
        public string? ProductoDescripcion { get; set; }
    }
}

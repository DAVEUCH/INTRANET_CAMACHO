using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VInfoCpPercepcion
    {
        public int ComprobanteId { get; set; }
        public DateTime PercepcionFechaEmision { get; set; }
        public string PercepcionNumCp { get; set; } = null!;
        public string PercepcionOrigenDestino { get; set; } = null!;
        public string PercepcionDocIdentidad { get; set; } = null!;
        public string PercepcionDireccion { get; set; } = null!;
        public decimal PercepcionTotal { get; set; }
        public string PercepcionDistrito { get; set; } = null!;
        public string PercepcionMoneda { get; set; } = null!;
        public string PercepcionMonedaSim { get; set; } = null!;
        public string DetalleCpCodigo { get; set; } = null!;
        public string DetalleCpNumero { get; set; } = null!;
        public string DetalleCpTipo { get; set; } = null!;
        public DateTime DetalleCpFechaEmision { get; set; }
        public string DetalleCodigoSunat { get; set; } = null!;
        public decimal DetallePrecioVenta { get; set; }
        public decimal DetalleMontoPercepcion { get; set; }
        public decimal? DetallePorcenPercepcion { get; set; }
        public decimal DetalleMontoTotal { get; set; }
        public string? PercepcionMontoLetras { get; set; }
    }
}

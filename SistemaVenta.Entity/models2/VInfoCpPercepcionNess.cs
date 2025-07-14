using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VInfoCpPercepcionNess
    {
        public int Pkid { get; set; }
        public string ComprobanteNumCp { get; set; } = null!;
        public string ClienteNombre { get; set; } = null!;
        public string? ClienteDocumento { get; set; }
        public DateTime FechaEmision { get; set; }
        public string ItemComprobanteTipoCp { get; set; } = null!;
        public string ItemNumCp { get; set; } = null!;
        public DateTime ItemFechaEmision { get; set; }
        public decimal ItemPrecioVenta { get; set; }
        public decimal ItemPorcentajePercepcion { get; set; }
        public decimal ItemImportePercepcion { get; set; }
        public decimal? ItemMontoTotalCobrado { get; set; }
        public decimal ImporteTotalMontoPercibido { get; set; }
        public string? TotalImporteLetras { get; set; }
        public int Moneda { get; set; }
    }
}

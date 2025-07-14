using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteVentasDetComprobantes01
    {
        public int SucursalId { get; set; }
        public string SucursalCodigo { get; set; } = null!;
        public string SucursalNombre { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string? Hora { get; set; }
        public string TipoComprobante { get; set; } = null!;
        public string NumeroComprobante { get; set; } = null!;
        public string ModalidadCredito { get; set; } = null!;
        public int ModalidadCreditoCod { get; set; }
        public int ClienteId { get; set; }
        public string ClienteNombre { get; set; } = null!;
        public int VendedorId { get; set; }
        public string VendedorNombre { get; set; } = null!;
        public decimal? TotalASoles { get; set; }
        public decimal? TotalADolares { get; set; }
        public decimal? Total { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteVentasComprobantescLiente
    {
        public DateTime Fecha { get; set; }
        public string? Hora { get; set; }
        public int SucursalId { get; set; }
        public string SucursalNombre { get; set; } = null!;
        public string TipoComprobante { get; set; } = null!;
        public string NumeroComprobante { get; set; } = null!;
        public string ModalidadDeCredito { get; set; } = null!;
        public int ClienteId { get; set; }
        public string ClienteNombre { get; set; } = null!;
        public decimal? TotalConIgv { get; set; }
    }
}

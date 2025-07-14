using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvDocumContadoPorCobrarFreddy
    {
        public DateTime Fecha { get; set; }
        public string? Hora { get; set; }
        public int SucursalId { get; set; }
        public string SucursalNombre { get; set; } = null!;
        public string TipoComprobante { get; set; } = null!;
        public string NumeroComprobante { get; set; } = null!;
        public string ModalidadCredito { get; set; } = null!;
        public int ClienteId { get; set; }
        public string ClienteNombre { get; set; } = null!;
        public string? ClienteLocalidad { get; set; }
        public string Moneda { get; set; } = null!;
        public decimal Total { get; set; }
        public decimal SaldoSol { get; set; }
        public decimal SaldoDol { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VHelperLineaCreditoCpCobrarPagar
    {
        public DateTime Fecha { get; set; }
        public DateTime FechaEmision { get; set; }
        public int Idmoneda { get; set; }
        public int Idpersona { get; set; }
        public int IdmodalidadCredito { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public decimal Saldo { get; set; }
        public string TipoCpCobrarPagar { get; set; } = null!;
        public decimal Total { get; set; }
        public int Pkid { get; set; }
        public int DiasCredito { get; set; }
        public bool Anulado { get; set; }
    }
}

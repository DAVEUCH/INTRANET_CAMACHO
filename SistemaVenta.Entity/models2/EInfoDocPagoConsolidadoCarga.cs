using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EInfoDocPagoConsolidadoCarga
    {
        public int Id { get; set; }
        public int IdcargoAbono { get; set; }
        public int Idcp { get; set; }
        public int IdcuentaContable { get; set; }
        public int Idauxiliar { get; set; }
        public DateTime FechaUltimoPago { get; set; }
        public decimal Saldo { get; set; }
        public decimal Total { get; set; }
        public bool Pagado { get; set; }
        public bool Anulado { get; set; }
        public int Idpersona { get; set; }
        public string Doc { get; set; } = null!;
        public string Numero { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string Simbolo { get; set; } = null!;
        public bool Credito { get; set; }
        public string Nombre { get; set; } = null!;
        public string Codigo { get; set; } = null!;
        public bool MonedaBase { get; set; }
        public string TipoCpCobrarPagar { get; set; } = null!;
        public bool MonedaBaseMoneda { get; set; }
    }
}

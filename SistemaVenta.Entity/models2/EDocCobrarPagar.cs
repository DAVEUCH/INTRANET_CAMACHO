using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EDocCobrarPagar
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
        public int IdcentroDeCosto { get; set; }
        public string TipoDocPago { get; set; } = null!;
    }
}

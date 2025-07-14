using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VCuentasPorPagarMigracion
    {
        public string Documento { get; set; } = null!;
        public int Pkid { get; set; }
        public string Numero { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public DateTime FechaEmision { get; set; }
        public string ProveedorCodigo { get; set; } = null!;
        public string ProveedorNombre { get; set; } = null!;
        public string Moneda { get; set; } = null!;
        public decimal Total { get; set; }
        public decimal Saldo { get; set; }
        public int Idpersona { get; set; }
        public bool MonedaBase { get; set; }
        public string TipoCpCobrarPagar { get; set; } = null!;
    }
}

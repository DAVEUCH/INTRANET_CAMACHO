using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class RptLibroDiario
    {
        public string TipoVoucher { get; set; } = null!;
        public string NumCp { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string Glosa { get; set; } = null!;
        public string? NumeroCuenta { get; set; }
        public string? NombreCuenta { get; set; }
        public string TipoCpRelacionado { get; set; } = null!;
        public string NumCpRelacionado { get; set; } = null!;
        public decimal Cargo { get; set; }
        public decimal Abono { get; set; }
        public int Idperiodo { get; set; }
    }
}

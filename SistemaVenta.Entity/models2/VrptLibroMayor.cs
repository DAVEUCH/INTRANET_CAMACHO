using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptLibroMayor
    {
        public string? Cuenta { get; set; }
        public string? NombreCuenta { get; set; }
        public string Glosa { get; set; } = null!;
        public string NumVoucher { get; set; } = null!;
        public DateTime FechaVoucher { get; set; }
        public string CpRelacionado { get; set; } = null!;
        public string NumCpRelacionado { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public decimal Cargo { get; set; }
        public decimal Abono { get; set; }
        public decimal? Saldo { get; set; }
        public int Idperiodo { get; set; }
    }
}

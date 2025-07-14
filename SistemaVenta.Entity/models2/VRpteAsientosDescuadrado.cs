using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VRpteAsientosDescuadrado
    {
        public string TipoVoucher { get; set; } = null!;
        public string NumVoucher { get; set; } = null!;
        public DateTime FechaVoucher { get; set; }
        public string TipoOperacion { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public decimal? Cargo { get; set; }
        public decimal? Abono { get; set; }
        public decimal? Saldo { get; set; }
        public string? TipoCp { get; set; }
        public string? NumCp { get; set; }
        public DateTime? FechaCp { get; set; }
    }
}

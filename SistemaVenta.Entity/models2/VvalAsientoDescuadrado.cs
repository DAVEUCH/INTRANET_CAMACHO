using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VvalAsientoDescuadrado
    {
        public int Idvoucher { get; set; }
        public int Idasiento { get; set; }
        public string NumCp { get; set; } = null!;
        public decimal? Cargo { get; set; }
        public decimal? Abono { get; set; }
        public decimal? Saldo { get; set; }
    }
}

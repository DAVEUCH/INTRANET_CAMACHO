using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VvalCpCobrarPagarSaldo
    {
        public int Pkid { get; set; }
        public int Idsucursal { get; set; }
        public DateTime DocumentoCargoFecha { get; set; }
        public string DocumentoCargoNumero { get; set; } = null!;
        public decimal DocumentoCargoTotal { get; set; }
        public decimal DocumentoCargoSaldo { get; set; }
        public decimal? Amortizacion { get; set; }
        public decimal? Saldo { get; set; }
    }
}

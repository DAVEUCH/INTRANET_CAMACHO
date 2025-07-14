using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TmpPresaldocontable3
    {
        public string? Cuenta { get; set; }
        public int? Pkid { get; set; }
        public DateTime? Fecha { get; set; }
        public string? NumCp { get; set; }
        public string? TipoCpCobrarPagar { get; set; }
        public decimal? SaldoSoles { get; set; }
        public decimal? SaldoDolares { get; set; }
        public decimal? SaldoSolesContable { get; set; }
        public decimal? SaldoDolaresContable { get; set; }
        public decimal? SaldoDolaresContableNuevo { get; set; }
    }
}

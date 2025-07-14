using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VWapConsultaCobranza
    {
        public int Idvendedor { get; set; }
        public DateTime Fecha { get; set; }
        public string CodigoCliente { get; set; } = null!;
        public string? Numero { get; set; }
        public decimal Total { get; set; }
        public decimal Saldo { get; set; }
        public int Idsupervisor { get; set; }
        public decimal? Amortizacion { get; set; }
        public decimal PagoDolares { get; set; }
        public int Pkid { get; set; }
    }
}

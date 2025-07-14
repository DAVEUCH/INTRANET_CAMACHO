using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VCpVentaDeConsolidado
    {
        public int Id { get; set; }
        public string TipoCp { get; set; } = null!;
        public string NumCp { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string CodigoCliente { get; set; } = null!;
        public string? PersonaNombre { get; set; }
        public decimal Total { get; set; }
        public bool Credito { get; set; }
        public DateTime FechaEmision { get; set; }
        public bool Anulado { get; set; }
        public int? IdconsolidadoCarga { get; set; }
        public int IdzonaReparto { get; set; }
        public int IdzonaVenta { get; set; }
    }
}

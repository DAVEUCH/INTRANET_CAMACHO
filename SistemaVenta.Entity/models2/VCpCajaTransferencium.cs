using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VCpCajaTransferencium
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string TipoCp { get; set; } = null!;
        public string NumCp { get; set; } = null!;
        public decimal Total { get; set; }
        public string Concepto { get; set; } = null!;
        public decimal TotalSoles { get; set; }
        public string CajaOrigenCodigo { get; set; } = null!;
        public string CajaOrigenDescripcion { get; set; } = null!;
        public decimal TotalDolares { get; set; }
        public string Anulado { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Preacumuladogeneral1
    {
        public string NumCp { get; set; } = null!;
        public int Pkid { get; set; }
        public decimal? ValorVenta { get; set; }
        public decimal? ValorAfecto { get; set; }
        public int? Inafecto { get; set; }
        public decimal? ValorUnitario { get; set; }
        public decimal? Total { get; set; }
        public decimal? Cantidad { get; set; }
        public bool Anulado { get; set; }
        public decimal? ValorVentatotal { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public int Pk { get; set; }
        public int Idresponsable { get; set; }
        public DateTime Fecha { get; set; }
        public int Pkidcp { get; set; }
    }
}

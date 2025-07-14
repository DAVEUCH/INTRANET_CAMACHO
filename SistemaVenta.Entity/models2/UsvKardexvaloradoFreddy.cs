using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvKardexvaloradoFreddy
    {
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public string? TipoOperacionCodigo { get; set; }
        public string? TipoOperacionDescripcion { get; set; }
        public decimal? ValorEntrada { get; set; }
        public decimal? ValorSalida { get; set; }
    }
}

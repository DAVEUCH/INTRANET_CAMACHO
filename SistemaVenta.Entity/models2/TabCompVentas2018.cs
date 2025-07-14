using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TabCompVentas2018
    {
        public int Idventa { get; set; }
        public string NumCp { get; set; } = null!;
        public string? CodigoTipoCp { get; set; }
        public string? Año { get; set; }
        public string? Mes { get; set; }
        public int? CantidadUnidadBase { get; set; }
        public decimal? ValorVentaDolares { get; set; }
        public decimal? TotalDolares { get; set; }
    }
}

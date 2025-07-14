using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VInfoCpVentaJaime
    {
        public DateTime FechaEmision { get; set; }
        public string CodigoVendedor { get; set; } = null!;
        public string NombreVendedor { get; set; } = null!;
        public string CodigoGrupoVentas { get; set; } = null!;
        public string NombreGrupoVentas { get; set; } = null!;
        public string CodigoProveedor { get; set; } = null!;
        public string NombreProveedor { get; set; } = null!;
        public string CodigoLinea { get; set; } = null!;
        public string NombreLinea { get; set; } = null!;
        public string Marca { get; set; } = null!;
        public decimal? ValorAfecto { get; set; }
        public decimal? ValorInafecto { get; set; }
        public decimal? ValorVenta { get; set; }
        public decimal? Igv { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? Total { get; set; }
        public bool PreciosIncImpto { get; set; }
    }
}

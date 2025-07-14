using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TabVentasPorMarcaProductosAñosMese
    {
        public int? MarcaId { get; set; }
        public string? MarcaCodigo { get; set; }
        public string? MarcaDescripcion { get; set; }
        public int? ProductoId { get; set; }
        public string? ProductoCodigo { get; set; }
        public int? TransacVentas { get; set; }
        public int? CantidadUnidadBase { get; set; }
        public int? CantidadClientes { get; set; }
        public decimal? ImpVentasSol { get; set; }
        public decimal? ImpVentasDol { get; set; }
        public string? Año { get; set; }
        public int? Mes { get; set; }
    }
}

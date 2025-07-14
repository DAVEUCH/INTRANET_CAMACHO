using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TabVentasPorMarcaProductosAnual
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
        public decimal? TotVentasDol { get; set; }
        public string? Año { get; set; }
        public decimal? Ene { get; set; }
        public decimal? Feb { get; set; }
        public decimal? Mar { get; set; }
        public decimal? Abr { get; set; }
        public decimal? May { get; set; }
        public decimal? Jun { get; set; }
        public decimal? Jul { get; set; }
        public decimal? Ago { get; set; }
        public decimal? Sep { get; set; }
        public decimal? Oct { get; set; }
        public decimal? Nov { get; set; }
        public decimal? Dic { get; set; }
    }
}

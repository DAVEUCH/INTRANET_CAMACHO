using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EDefinicionReglaDescuento
    {
        public int ReglasDescuentoId { get; set; }
        public string ReglasDescuentoRutaCaracteristicaEstructural { get; set; } = null!;
        public string ReglasDescuentoRutaAtributoBusqueda { get; set; } = null!;
        public string? ReglasDescuentoCondicion { get; set; }
        public int? ReglasDescuentoValorEnTexto { get; set; }
        public string ReglasDescuentoEnlace { get; set; } = null!;
        public string? ReglasDescuentoValorDesde { get; set; }
        public string? ReglasDescuentoValorHasta { get; set; }
        public string? ReglasDescuentoRutaAgrupacion { get; set; }
        public string? ReglasDescuentoOperacionAgrupacion { get; set; }
        public int IddefinicionGrupoReglaDescuento { get; set; }
        public bool? ReglasDescuentoEsReglaExclusion { get; set; }
        public bool? ReglasDescuentoTieneReglaExclusion { get; set; }
        public int? ReglasDescuentoReglaExclusionId { get; set; }
        public int Id { get; set; }
        public bool? EsReglaExclusion { get; set; }
        public string? RutaAgrupacion { get; set; }
        public int? IdreglaExclusion { get; set; }
        public string? Condicion { get; set; }
        public string RutaCaracteristicaEstructural { get; set; } = null!;
        public string RutaAtributoBusqueda { get; set; } = null!;
        public string? OperacionAgrupacion { get; set; }
        public string? ValorHasta { get; set; }
        public string? ValorDesde { get; set; }
        public string Enlace { get; set; } = null!;
        public bool? TieneReglaExclusion { get; set; }
        public int? ReglaExclusionId { get; set; }
    }
}

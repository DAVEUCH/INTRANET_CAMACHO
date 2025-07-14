using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EDefinicionReglaBonificacion
    {
        public int ReglasBonificacionId { get; set; }
        public int IddefinicionGrupoReglaBonificacion { get; set; }
        public string ReglasBonificacionRutaCaracteristicaEstructural { get; set; } = null!;
        public string ReglasBonificacionRutaAtributoBusqueda { get; set; } = null!;
        public string? ReglasBonificacionCondicion { get; set; }
        public string? ReglasBonificacionValorEnTexto { get; set; }
        public string ReglasBonificacionEnlace { get; set; } = null!;
        public string? ReglasBonificacionValorDesde { get; set; }
        public string? ReglasBonificacionValorHasta { get; set; }
        public string? ReglasBonificacionRutaAgrupacion { get; set; }
        public string? ReglasBonificacionOperacionAgrupacion { get; set; }
        public bool? ReglasBonificacionEsReglaExclusion { get; set; }
        public bool? ReglasBonificacionTieneReglaExclusion { get; set; }
        public int? ReglasBonificacionReglaExclusionId { get; set; }
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
        public int? PorCada { get; set; }
        public int? ReglasBonificacionPorCada { get; set; }
    }
}

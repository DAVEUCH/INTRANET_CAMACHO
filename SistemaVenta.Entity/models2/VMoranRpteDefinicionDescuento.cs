using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VMoranRpteDefinicionDescuento
    {
        public int DefinicionId { get; set; }
        public string DefinicionCodigo { get; set; } = null!;
        public string DefinicionDescripcion { get; set; } = null!;
        public decimal DefinicionPorcentaje { get; set; }
        public int DefinicionTipoDescuentoId { get; set; }
        public string DefinicionTipoDescuentoDescripcion { get; set; } = null!;
        public bool? DefinicionSucesivo { get; set; }
        public string AgrupacionEnlace { get; set; } = null!;
        public int ReglaId { get; set; }
        public string ReglaCaracteristicaEstructural { get; set; } = null!;
        public string ReglaAtributoBusqueda { get; set; } = null!;
        public string? ReglaCondicion { get; set; }
        public int? ReglaValorEnTexto { get; set; }
        public string ReglaEnlace { get; set; } = null!;
        public string? ReglaValorDesde { get; set; }
        public string? ReglaValorHasta { get; set; }
        public string? ReglaRutaAgrupacion { get; set; }
        public string? ReglaOperacionAgrupacion { get; set; }
        public int ReglaEsExclusion { get; set; }
        public int ReglaTieneReglaExclusion { get; set; }
        public string? ColeccionEntidad { get; set; }
        public string? ColeccionDescripcion { get; set; }
        public int? ReglaExclusionId { get; set; }
        public string DescuentoRecargo { get; set; } = null!;
        public bool Estado { get; set; }
        public string? Linea { get; set; }
        public DateTime? FechaInicial { get; set; }
        public DateTime? FechaFinal { get; set; }
    }
}

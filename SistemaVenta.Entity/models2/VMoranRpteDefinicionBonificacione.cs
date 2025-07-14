using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VMoranRpteDefinicionBonificacione
    {
        public int DefinicionId { get; set; }
        public string DefinicionCodigo { get; set; } = null!;
        public string DefinicionDescripcion { get; set; } = null!;
        public string AgrupacionEnlace { get; set; } = null!;
        public int ReglaId { get; set; }
        public string ReglaCaracteristicaEstructural { get; set; } = null!;
        public string ReglaAtributoBusqueda { get; set; } = null!;
        public string? ReglaCondicion { get; set; }
        public string? ReglaValorEnTexto { get; set; }
        public string ReglaEnlace { get; set; } = null!;
        public string? ReglaValorDesde { get; set; }
        public string? ReglaValorHasta { get; set; }
        public string? ReglaRutaAgrupacion { get; set; }
        public string? ReglaOperacionAgrupacion { get; set; }
        public int ReglaEsExclusion { get; set; }
        public int ReglaTieneReglaExclusion { get; set; }
        public int? ReglaExclusionId { get; set; }
        public int? ReglaPorCada { get; set; }
        public string? ColeccionEntidad { get; set; }
        public string? ColeccionDescripcion { get; set; }
        public int Grupo { get; set; }
        public DateTime BonificacionDesde { get; set; }
        public DateTime BonificacionHasta { get; set; }
        public string BonificacionProductoCodigo { get; set; } = null!;
        public string BonificacionProductoDescripcion { get; set; } = null!;
        public string BonificacionUnidadAbreviacion { get; set; } = null!;
        public int BonificacionProductoCantidad { get; set; }
        public int BonificacionCantidadMaximaPedido { get; set; }
        public int BonificacionCantidadMaximaCliente { get; set; }
        public int BonificacionTieneCantidadPorCliente { get; set; }
        public bool Estado { get; set; }
        public string? Linea { get; set; }
        public DateTime? FechaInicial { get; set; }
        public DateTime? FechaFinal { get; set; }
    }
}

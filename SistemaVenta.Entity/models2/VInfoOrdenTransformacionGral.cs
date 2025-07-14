using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VInfoOrdenTransformacionGral
    {
        public string ProductoInsumoCodigo { get; set; } = null!;
        public string ProductoInsumoDescripcion { get; set; } = null!;
        public decimal ProductoInsumoPeso { get; set; }
        public string ProductoInsumoUnidadAbreviacion { get; set; } = null!;
        public decimal ProductoInsumoUnidadCantidad { get; set; }
        public decimal ProductoInsumoUnidadPeso { get; set; }
        public decimal ProductoInsumoUnidadVolumen { get; set; }
        public string ProductoInsumoObservacion { get; set; } = null!;
        public decimal ProductoInsumoValorUnitario { get; set; }
        public decimal ProductoInsumoValorVenta { get; set; }
        public decimal ProductoInsumoValorTotal { get; set; }
        public string ProductoTransformadoCodigo { get; set; } = null!;
        public string ProductoTransformadoDescripcion { get; set; } = null!;
        public decimal ProductoTransformadoUnidadCantidad { get; set; }
        public string ProductoTransformadoUnidadAbreviacion { get; set; } = null!;
        public string AlmacenEntradaCodigo { get; set; } = null!;
        public string AlmacenEntradaNombre { get; set; } = null!;
        public int ItemProductoInsumoId { get; set; }
        public int CpId { get; set; }
        public int OrdenTransformacionId { get; set; }
        public string OrdenTransformacionTipoCodigo { get; set; } = null!;
        public string OrdenTransformacionTipoDescripcion { get; set; } = null!;
        public string OrdenTransformacionNumero { get; set; } = null!;
        public string OrdenTransformacionObservacion { get; set; } = null!;
        public string? OrdenTransformacionPersona { get; set; }
        public string OrdenTransformacionEstadoSalida { get; set; } = null!;
        public string OrdenTransformacionEstadoEntrada { get; set; } = null!;
        public string OrdenTransformacionEstadoAprobacion { get; set; } = null!;
        public bool OrdenTransformacionCerrado { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaEmision { get; set; }
    }
}

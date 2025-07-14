using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptProduccionAvanceDetalle
    {
        public int OrdenPadreId { get; set; }
        public DateTime OrdenPadreFecha { get; set; }
        public string OrdenPadreNumero { get; set; } = null!;
        public string OrdenPadreTipoCp { get; set; } = null!;
        public int OrdenPadreProductoId { get; set; }
        public string OrdenPadreProductoCodigo { get; set; } = null!;
        public string OrdenPadreProductoNombre { get; set; } = null!;
        public int OrdenPadreUnidadId { get; set; }
        public string OrdenPadreUnidadNombre { get; set; } = null!;
        public int OrdenPadreUnidadFactor { get; set; }
        public decimal OrdenPadreCantidadProducir { get; set; }
        public decimal OrdenPadreCantidadProducirReal { get; set; }
        public string OrdenPadreEstadoAprobacion { get; set; } = null!;
        public string OrdenPadreEstadoSalida { get; set; } = null!;
        public string OrdenPadreEstadoEntrada { get; set; } = null!;
        public decimal OrdenPadreBalanceEntrada { get; set; }
        public int OrdenHijoId { get; set; }
        public DateTime OrdenHijoFecha { get; set; }
        public string OrdenHijoNumero { get; set; } = null!;
        public string OrdenHijoTipoCp { get; set; } = null!;
        public int OrdenHijoProductoId { get; set; }
        public string OrdenHijoProductoCodigo { get; set; } = null!;
        public string OrdenHijoProductoNombre { get; set; } = null!;
        public int OrdenHijoUnidadId { get; set; }
        public string OrdenHijoUnidadNombre { get; set; } = null!;
        public int OrdenHijoUnidadFactor { get; set; }
        public decimal OrdenHijoCantidadProducir { get; set; }
        public decimal OrdenHijoCantidadProducirReal { get; set; }
        public string OrdenHijoEstadoAprobacion { get; set; } = null!;
        public string OrdenHijoEstadoSalida { get; set; } = null!;
        public string OrdenHijoEstadoEntrada { get; set; } = null!;
        public decimal OrdenHijoBalanceEntrada { get; set; }
        public int DetalleProductoId { get; set; }
        public string DetalleProductoCodigo { get; set; } = null!;
        public string DetalleProductoNombre { get; set; } = null!;
        public int DetalleProductoCantidadBase { get; set; }
        public int DetalleProductoFactor { get; set; }
        public string DetalleUnidad { get; set; } = null!;
        public decimal DetalleBalanceEntrada { get; set; }
        public decimal? DetalleCantidadReceta { get; set; }
    }
}

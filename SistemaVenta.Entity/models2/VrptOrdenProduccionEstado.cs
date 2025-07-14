using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptOrdenProduccionEstado
    {
        public int OrdenId { get; set; }
        public string OrdenTipoCpDescripcion { get; set; } = null!;
        public string OrdenNumero { get; set; } = null!;
        public DateTime OrdenFecha { get; set; }
        public decimal OrdenTotal { get; set; }
        public string OrdenEstadoSalida { get; set; } = null!;
        public string OrdenEstadoEntrada { get; set; } = null!;
        public string OrdenEstadoAprobacion { get; set; } = null!;
        public bool OrdenCerrado { get; set; }
        public string OrdenObservacion { get; set; } = null!;
        public string OrdenCliente { get; set; } = null!;
        public string OrdenProducto { get; set; } = null!;
        public string OrdenProductoCod { get; set; } = null!;
        public decimal OrdenProductoCantidad { get; set; }
        public string OrdenProductoUnidad { get; set; } = null!;
        public int OrdenProductoUnidadFactor { get; set; }
    }
}

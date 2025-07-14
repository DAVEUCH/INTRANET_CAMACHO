using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VMoranRptNotaCredito
    {
        public string? ClienteNombre { get; set; }
        public string ClienteDireccion { get; set; } = null!;
        public string ClienteDocIdentidad { get; set; } = null!;
        public string ComprobanteReferenciaNumero { get; set; } = null!;
        public DateTime ComprobanteReferenciaFechaEmision { get; set; }
        public string ComprobanteNumero { get; set; } = null!;
        public string? Clientecodigo { get; set; }
        public string? ComprobanteModalidadCredito { get; set; }
        public decimal ItemCantidad { get; set; }
        public string ItemDescripcion { get; set; } = null!;
        public decimal ItemValorUnitario { get; set; }
        public decimal ItemValorVenta { get; set; }
        public decimal ItemValorAfecto { get; set; }
        public decimal ItemSubTotal { get; set; }
        public decimal ItemTotal { get; set; }
        public string ItemCodigoProducto { get; set; } = null!;
        public decimal ComprobanteTotal { get; set; }
        public decimal ComprobanteValorAfecto { get; set; }
        public decimal ComprobanteValorInafecto { get; set; }
        public decimal ComprobanteValorVenta { get; set; }
        public decimal ComprobanteSubTotal { get; set; }
        public decimal ComprobanteValorDescuento { get; set; }
        public bool ItemBonificacion { get; set; }
        public decimal ItemValorDescuento { get; set; }
        public decimal ItemValorInafecto { get; set; }
        public decimal ItemImpuesto { get; set; }
        public int IdComprobante { get; set; }
        public string ItemUnidad { get; set; } = null!;
        public bool Inafecto { get; set; }
        public decimal PorcentajeImpto { get; set; }
        public decimal? ComprobantePercepcion { get; set; }
        public bool? ComprobanteAplicaPercepcion { get; set; }
        public decimal? ComprobantePorcentajePercepcion { get; set; }
        public DateTime ComprobanteFechaEmision { get; set; }
        public decimal ComprobanteImpuesto { get; set; }
        public string ZonaVenta { get; set; } = null!;
        public string? Descripcion { get; set; }
        public bool ItemAplicaPercepcion { get; set; }
    }
}

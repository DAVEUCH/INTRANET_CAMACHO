using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VInfoCpVentaNotaDebitoFreddy
    {
        public int ComprobantePkid { get; set; }
        public string ComprobanteNumCp { get; set; } = null!;
        public DateTime ComprobanteFechaEmision { get; set; }
        public string ComprobanteClienteNombre { get; set; } = null!;
        public string? ComprobanteClienteDocIdentidad { get; set; }
        public string ComprobanteClienteDireccion { get; set; } = null!;
        public string ComprobanteVendedorCodigo { get; set; } = null!;
        public string? ComprobanteRelacionadoNumCp { get; set; }
        public DateTime? ComprobanteRelacionadoFechaEmision { get; set; }
        public decimal ItemProductoCantidad { get; set; }
        public string? ItemProductoUnidad { get; set; }
        public string? ItemProductoCodigo { get; set; }
        public string? ItemProductoDescripcion { get; set; }
        public decimal ItemProductoValorUnitario { get; set; }
        public decimal ItemProductoTotal { get; set; }
        public decimal ComprobanteValorVenta { get; set; }
        public decimal? ComprobanteIgv { get; set; }
        public decimal ComprobanteTotal { get; set; }
        public string? ComprobanteTotalEnLetras { get; set; }
        public string? ComprobanteRelacionadoTipoCp { get; set; }
        public bool ComprobanteMoneda { get; set; }
    }
}

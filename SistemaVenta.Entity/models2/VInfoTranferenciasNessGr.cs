using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VInfoTranferenciasNessGr
    {
        public int? ComprobantePkid { get; set; }
        public string? ComprobanteNumCp { get; set; }
        public string ComprobanteClienteNombre { get; set; } = null!;
        public string ComprobanteClienteDocIdentidad { get; set; } = null!;
        public string ComprobanteDireccionEntrega2 { get; set; } = null!;
        public DateTime? ComprobanteFechaEmision { get; set; }
        public string? ComprobanteTransportistaNombre { get; set; }
        public string? ComprobanteDireccionPartida { get; set; }
        public string? ComprobanteVehiculoPlaca { get; set; }
        public string? ComprobanteVehiculoMarca { get; set; }
        public string? ComprobanteVehiculoModelo { get; set; }
        public string? ComprobanteVehiculoCertificadoInscripcion { get; set; }
        public decimal? ItemProductoCantidad { get; set; }
        public string? ItemProductoUnidad { get; set; }
        public string? ItemProductoCodigoInterno { get; set; }
        public string? ItemProductoDescripcion { get; set; }
        public decimal? ItemProductoValorUnitario { get; set; }
        public decimal? ItemProductoDescuento { get; set; }
        public decimal? ItemProductoTotal { get; set; }
        public decimal? ComprobanteTotal { get; set; }
        public string? ComprobantePosteriorNumCpOld { get; set; }
        public DateTime? ComprobantePosteriorFechaEmision { get; set; }
        public string? ComprobanteObservacion { get; set; }
        public string? ItemProductoCodigo { get; set; }
        public string ComprobanteDireccionEntrega { get; set; } = null!;
        public int? IdcpInventarioEntrada { get; set; }
        public int? IdcpInventarioSalida { get; set; }
        public string Direccion { get; set; } = null!;
        public string? Nombre { get; set; }
        public string? ComprobantePosteriorNumCp { get; set; }
        public int? ComprobantePosteriorPkid { get; set; }
    }
}

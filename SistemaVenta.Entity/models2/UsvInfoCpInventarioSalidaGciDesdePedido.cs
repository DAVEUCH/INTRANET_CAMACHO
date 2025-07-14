using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvInfoCpInventarioSalidaGciDesdePedido
    {
        public int ComprobantePkid { get; set; }
        public string ComprobanteNumCp { get; set; } = null!;
        public string? ComprobanteClienteNombre { get; set; }
        public string? ComprobanteClienteDocIdentidad { get; set; }
        public DateTime ComprobanteFechaEmision { get; set; }
        public string ComprobanteDireccionPartida { get; set; } = null!;
        public string? ComprobanteTransportistaNombre { get; set; }
        public string? ComprobanteVehiculoPlaca { get; set; }
        public string? ComprobanteVehiculoMarca { get; set; }
        public string? ComprobanteVehiculoModelo { get; set; }
        public string? ComprobanteVehiculoCertificadoInscripcion { get; set; }
        public decimal ItemProductoCantidad { get; set; }
        public string? ItemProductoUnidad { get; set; }
        public string? ItemProductoCodigo { get; set; }
        public string? ItemProductoCodigoInterno { get; set; }
        public string? ItemProductoDescripcion { get; set; }
        public decimal ItemProductoValorUnitario { get; set; }
        public decimal ItemProductoTotal { get; set; }
        public decimal ComprobanteTotal { get; set; }
        public string? ComprobantePosteriorNumCp { get; set; }
        public DateTime? ComprobantePosteriorFechaEmision { get; set; }
        public string ComprobanteObservacion { get; set; } = null!;
        public string? ClienteDireccion { get; set; }
        public string? ComprobanteDireccionEntrega2 { get; set; }
        public string? ComprobanteDireccionEntrega { get; set; }
        public string Distrito { get; set; } = null!;
        public string Provincia { get; set; } = null!;
        public string Departamento { get; set; } = null!;
        public string DireccionClienteEnvio { get; set; } = null!;
        public bool EsAgrupacion { get; set; }
    }
}

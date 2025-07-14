using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VInfoCpVentaBoletaFreddy
    {
        public int ComprobantePkid { get; set; }
        public string NumCp { get; set; } = null!;
        public string ComprobanteClienteNombre { get; set; } = null!;
        public string VendedorNombre { get; set; } = null!;
        public string ComprobanteClienteDireccion { get; set; } = null!;
        public DateTime ComprobanteFechaEmision { get; set; }
        public string? ComprobanteClienteDocIdentidad { get; set; }
        public decimal ItemProductoCantidad { get; set; }
        public string? ItemProductoUnidad { get; set; }
        public string? ItemProductoCodigoInterno { get; set; }
        public string? ProductoDescripcion { get; set; }
        public string? ItemProductoDescripcion { get; set; }
        public decimal? ItemProductoValorUnitario { get; set; }
        public decimal? ItemProductoTotal { get; set; }
        public decimal? ComprobanteTotal { get; set; }
        public string? ComprobanteTotalEnLetras { get; set; }
        public int IdtipoCp { get; set; }
        public bool ComprobanteMoneda { get; set; }
        public string? ItemProductoCodigo { get; set; }
    }
}

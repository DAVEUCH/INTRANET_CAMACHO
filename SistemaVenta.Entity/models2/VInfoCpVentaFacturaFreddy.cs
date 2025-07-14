using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VInfoCpVentaFacturaFreddy
    {
        public int ComprobantePkid { get; set; }
        public string NumCp { get; set; } = null!;
        public string? ComprobanteClienteNombre { get; set; }
        public string? ComprobanteClienteDocIdentidad { get; set; }
        public string ComprobanteClienteDireccion { get; set; } = null!;
        public string ComprobanteClienteDireccionEntrega { get; set; } = null!;
        public DateTime ComprobanteFechaEmision { get; set; }
        public string Modalidad { get; set; } = null!;
        public string? ProductoCodigo { get; set; }
        public string? ProductoDescripcion { get; set; }
        public string? ProductoDescripcionResumida { get; set; }
        public decimal ProductoCantidad { get; set; }
        public string UnidadMedida { get; set; } = null!;
        public decimal? PrecioLista { get; set; }
        public decimal? ImporteBruto { get; set; }
        public decimal DescuentoAplicado { get; set; }
        public decimal ValorAfecto { get; set; }
        public decimal ValorInafecto { get; set; }
        public bool ComprobanteCredito { get; set; }
        public string ComprobanteVendedorNombre { get; set; } = null!;
        public string? ItemProductoMarca { get; set; }
        public string? ItemProductoCodigoInterno { get; set; }
        public string? ItemProductoDescripcion { get; set; }
        public decimal ItemProductoCantidad { get; set; }
        public string? ItemProductoUnidad { get; set; }
        public decimal? ItemProductoValorUnitario { get; set; }
        public decimal? ItemProductoTotalDescuento { get; set; }
        public decimal? ComprobanteValorVenta { get; set; }
        public decimal? ComprobanteIgv { get; set; }
        public decimal? ComprobanteTotal { get; set; }
        public string? ComprobanteTotalEnLetras { get; set; }
        public decimal? ComprobanteDescuentoPorcentaje { get; set; }
        public string? ComprobanteNumcpRelacionado { get; set; }
        public int IdtipoCp { get; set; }
        public int? ItemProductoTipoItemCp { get; set; }
        public bool ComprobanteMoneda { get; set; }
        public string? ItemProductoCodigo { get; set; }
        public string DiasCredito { get; set; } = null!;
        public int Pkid { get; set; }
    }
}

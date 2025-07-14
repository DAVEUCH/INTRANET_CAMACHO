using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvReportePedidoDetalleconGuiasStock
    {
        public int Idsucursal { get; set; }
        public string NombreSucursal { get; set; } = null!;
        public string TipoDoc { get; set; } = null!;
        public string NumeroPedido { get; set; } = null!;
        public string? NumeroSalida { get; set; }
        public DateTime Fecha { get; set; }
        public string? Hora { get; set; }
        public string? EstadoFacturacion { get; set; }
        public string? EstadoEntrega { get; set; }
        public string? Cliente { get; set; }
        public string? Responsable { get; set; }
        public string CodigoProd { get; set; } = null!;
        public string DescripProd { get; set; } = null!;
        public string? Segmento { get; set; }
        public decimal Cantidad { get; set; }
        public string UnidMedida { get; set; } = null!;
        public int? StockFisico { get; set; }
        public string EstadoAnulado { get; set; } = null!;
    }
}

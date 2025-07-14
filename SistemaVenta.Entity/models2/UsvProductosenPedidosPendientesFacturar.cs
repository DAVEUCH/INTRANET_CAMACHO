using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvProductosenPedidosPendientesFacturar
    {
        public int Idsucursal { get; set; }
        public string NombreSucursal { get; set; } = null!;
        public string TipoDoc { get; set; } = null!;
        public string NumeroPedido { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public string EstadoFacturacion { get; set; } = null!;
        public string? Cliente { get; set; }
        public string? Responsable { get; set; }
        public string CodigoProd { get; set; } = null!;
        public string DescripProd { get; set; } = null!;
        public decimal Cantidad { get; set; }
        public decimal ValorUnitario { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VMoranPedidoDetalle
    {
        public int Pkid { get; set; }
        public DateTime FechaEmision { get; set; }
        public string NumCp { get; set; } = null!;
        public int Idcliente { get; set; }
        public string ClienteCodigo { get; set; } = null!;
        public string ClienteNombre { get; set; } = null!;
        public int Idvendedor { get; set; }
        public string VendedorCodigo { get; set; } = null!;
        public string VendedorNombre { get; set; } = null!;
        public string EstadoEntrega { get; set; } = null!;
        public string EstadoFacturacion { get; set; } = null!;
        public string EstadoAprobacion { get; set; } = null!;
        public string ItemProductoCodigo { get; set; } = null!;
        public string ItemProductoDescripcion { get; set; } = null!;
        public string ItemProductoAbreviacion { get; set; } = null!;
        public decimal ItemTotal { get; set; }
        public decimal ItemValorAfecto { get; set; }
        public decimal ItemValorInafecto { get; set; }
        public decimal ItemValorVenta { get; set; }
        public decimal? ItemPrecioUnitario { get; set; }
        public decimal ItemCantidad { get; set; }
        public decimal? ItemSubTotal { get; set; }
        public decimal ItemDsctoA { get; set; }
        public decimal ItemDsctoB { get; set; }
        public decimal ItemRecargo { get; set; }
        public decimal? ItemSubTotal2 { get; set; }
        public string? ItemDefinicionDescuentoId { get; set; }
        public int ItemDsctoSucesivo { get; set; }
        public decimal? ItemPorDsctoDefinicion { get; set; }
        public decimal? ItemPorDsctoAplicado { get; set; }
        public string? DefinicionBonificacionCodigo { get; set; }
        public bool Bonificacion { get; set; }
        public decimal ValorAfecto { get; set; }
        public decimal ValorInafecto { get; set; }
        public decimal Total { get; set; }
        public decimal ValorDescuento { get; set; }
        public int ItemCpId { get; set; }
        public decimal? TotalDsctoPieCp { get; set; }
        public decimal? TotalRecargoPieCp { get; set; }
        public decimal? TotalSubTotal { get; set; }
    }
}

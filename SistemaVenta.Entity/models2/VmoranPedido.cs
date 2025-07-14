using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VmoranPedido
    {
        public int VendedorId { get; set; }
        public string SupervisorNombre { get; set; } = null!;
        public int SupervisorId { get; set; }
        public string SupervisorCodigo { get; set; } = null!;
        public string VendedorCodigo { get; set; } = null!;
        public string VendedorNombre { get; set; } = null!;
        public string FuerzaVentasCodigo { get; set; } = null!;
        public string FuerzaVentasNombre { get; set; } = null!;
        public string PedidoNumero { get; set; } = null!;
        public int ClienteId { get; set; }
        public string ClienteNombre { get; set; } = null!;
        public string ClienteCodigo { get; set; } = null!;
        public DateTime PedidoFechaEmision { get; set; }
        public DateTime PedidoHoraGeneracion { get; set; }
        public decimal? PedidoTotal { get; set; }
        public int? PedidoItemsCantidad { get; set; }
        public DateTime? FechaGeneracion { get; set; }
        public int SucursalId { get; set; }
        public string SucursalNombre { get; set; } = null!;
        public string EtAprobacion { get; set; } = null!;
        public string EtFacturacion { get; set; } = null!;
        public int ModCreId { get; set; }
        public string ModCredito { get; set; } = null!;
        public string? ComprobanteNumero { get; set; }
        public decimal? ComprobanteTotal { get; set; }
        public DateTime? PedidoFechaAprobacion { get; set; }
        public string? ComprobanteTipoSunat { get; set; }
        public int? ClienteSecuencia { get; set; }
        public decimal? PedidoItemsPeso { get; set; }
        public string? ClienteLineaCredito { get; set; }
        public int? TotalClientes { get; set; }
        public string? ClienteZonaVenta { get; set; }
    }
}

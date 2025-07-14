using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VAdmPedidoFreddy
    {
        public bool Expr1 { get; set; }
        public int Id { get; set; }
        public string Doc { get; set; } = null!;
        public string NumCp { get; set; } = null!;
        public DateTime Hora { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaEmision { get; set; }
        public decimal Total { get; set; }
        public string Expr3 { get; set; } = null!;
        public string Moneda { get; set; } = null!;
        public string? PersonaNombre { get; set; }
        public int? PersonaTipoDocumentoLongitud { get; set; }
        public string PersonaTipoDocumento { get; set; } = null!;
        public string? PersonaDocIdentidad { get; set; }
        public string EstadoFacturacion { get; set; } = null!;
        public string EstadoEntrega { get; set; } = null!;
        public string EstadoAprobacion { get; set; } = null!;
        public string NumeroOrdenCompra { get; set; } = null!;
        public bool Cancelado { get; set; }
        public string SucursalNombre { get; set; } = null!;
        public string? ModalidadCredito { get; set; }
        public string? ZonaRepartoCodigo { get; set; }
        public string? ZonaRepartoDescripcion { get; set; }
        public string? DiaPedido { get; set; }
        public string? CodigoVehiculo { get; set; }
        public string? NombreVehiculo { get; set; }
        public int Expr4 { get; set; }
        public bool Ajustado { get; set; }
        public string Expr2 { get; set; } = null!;
        public string VendedorCodigo { get; set; } = null!;
        public string VendedorNombre { get; set; } = null!;
        public DateTime? FechaAprobacion { get; set; }
        public string? FuerzaVentas { get; set; }
        public decimal? TotalLinea { get; set; }
        public decimal? TotalSaldo { get; set; }
        public string? OrdenVisita { get; set; }
        public string? Estado { get; set; }
    }
}

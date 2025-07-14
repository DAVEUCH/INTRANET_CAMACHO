using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VPedidosVistaAdministrativa
    {
        public int Id { get; set; }
        public string Doc { get; set; } = null!;
        public string NumCp { get; set; } = null!;
        public DateTime Hora { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaEmision { get; set; }
        public decimal Total { get; set; }
        public string Anulado { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Moneda { get; set; } = null!;
        public string PersonaNombre { get; set; } = null!;
        public int? PersonaTipoDocumentoLongitud { get; set; }
        public string PersonaTipoDocumento { get; set; } = null!;
        public string PersonaDocIdentidad { get; set; } = null!;
        public string EstadoFacturacion { get; set; } = null!;
        public string EstadoEntrega { get; set; } = null!;
        public string EstadoAprobacion { get; set; } = null!;
        public string NumeroOrdenCompra { get; set; } = null!;
        public bool Cancelado { get; set; }
        public string SucursalNombre { get; set; } = null!;
        public string VendedorCodigo { get; set; } = null!;
        public string VendedorNombre { get; set; } = null!;
        public string? ModalidadCredito { get; set; }
        public string? ZonaRepartoCodigo { get; set; }
        public string? ZonaRepartoDescripcion { get; set; }
        public string? DiaPedido { get; set; }
        public int? IdzonaVenta { get; set; }
        public int? IdzonaReparto { get; set; }
    }
}

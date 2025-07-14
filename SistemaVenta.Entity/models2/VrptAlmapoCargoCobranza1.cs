using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptAlmapoCargoCobranza1
    {
        public int SucursalId { get; set; }
        public string SucursalNombre { get; set; } = null!;
        public int CargoCobranzaId { get; set; }
        public string CargoCobranzaTipoCpCodigo { get; set; } = null!;
        public string CargoCobranzaTipoCpAbrev { get; set; } = null!;
        public string CargoCobranzaNumero { get; set; } = null!;
        public DateTime CargoCobranzaFecha { get; set; }
        public int CargoCobranzaEmpleadoId { get; set; }
        public string CargoCobranzaEmpleadoCodigo { get; set; } = null!;
        public string CargoCobranzaEmpleadoNombre { get; set; } = null!;
        public decimal CargoCobranzaTotal { get; set; }
        public string CargoCobranzaEstado { get; set; } = null!;
        public string DetalleTipoComprobantePago { get; set; } = null!;
        public string DetalleTipoCp { get; set; } = null!;
        public string DetalleTipoCpCodigo { get; set; } = null!;
        public DateTime DetalleDocFechaEmision { get; set; }
        public string DetalleDocNumCp { get; set; } = null!;
        public int DetalleDocPersonaId { get; set; }
        public string? DetalleDocPersona { get; set; }
        public decimal DetalleDocTotal { get; set; }
        public decimal DetalleDocSaldo { get; set; }
        public decimal DetalleSaldo { get; set; }
        public string DetalleMedioPagoCodigo { get; set; } = null!;
        public string DetalleMedioPagoNombre { get; set; } = null!;
        public string? DetalleNumeroMedioPago { get; set; }
        public string? DetalleNumeroDocumento { get; set; }
        public decimal? DetalleMontoCobranza { get; set; }
        public int ComprobanteId { get; set; }
        public string DetalleDocPersonaCodigo { get; set; } = null!;
        public string? DetalleDocPersonaDireccionEntrega { get; set; }
        public string DetalleZonaVentaCodigo { get; set; } = null!;
        public string DetalleZonaVentaNombre { get; set; } = null!;
        public string DetalleZonaRepartoCodigo { get; set; } = null!;
        public string DetalleZonaRepartoNombre { get; set; } = null!;
        public string DetalleGrupoVentaCodigo { get; set; } = null!;
        public string DetalleGrupoVentaNombre { get; set; } = null!;
    }
}

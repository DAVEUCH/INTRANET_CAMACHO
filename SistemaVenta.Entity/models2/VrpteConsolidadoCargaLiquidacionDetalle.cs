using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteConsolidadoCargaLiquidacionDetalle
    {
        public int Pkid { get; set; }
        public int SucursalId { get; set; }
        public string ConsolidadoTipoCp { get; set; } = null!;
        public DateTime ConsolidadoFecha { get; set; }
        public int? ConsolidadoCerrado { get; set; }
        public decimal ConsolidadoPeso { get; set; }
        public decimal ConsolidadoVolumen { get; set; }
        public string ConsolidadoNumCp { get; set; } = null!;
        public string VehiculoCodigo { get; set; } = null!;
        public string VehiculoNombre { get; set; } = null!;
        public string ChoferCodigo { get; set; } = null!;
        public string ChoferNombre { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public int DetalleCpId { get; set; }
        public string DetalleCpTipoCpCodigo { get; set; } = null!;
        public DateTime DetalleCpFecha { get; set; }
        public string DetalleCpNumero { get; set; } = null!;
        public decimal? DetalleCpTotal { get; set; }
        public bool DetalleCpAnulado { get; set; }
        public string DetalleCpTipoCp { get; set; } = null!;
        public string DetalleResponsableCodigo { get; set; } = null!;
        public string DetalleResponsableNombre { get; set; } = null!;
        public string ModPago { get; set; } = null!;
        public decimal? VentaContado { get; set; }
        public decimal? VentaCredito { get; set; }
        public decimal? VentaContadoAnulado { get; set; }
        public decimal? VentaCreditoAnulado { get; set; }
        public decimal? RechazosContado { get; set; }
        public decimal? RechazosCredito { get; set; }
        public string Tipo { get; set; } = null!;
        public decimal? IngresoContado { get; set; }
        public decimal? EgresoContado { get; set; }
        public decimal? IngresoCredito { get; set; }
        public decimal? EgresoCredito { get; set; }
        public int Orden { get; set; }
        public int? DocPagadoId { get; set; }
        public DateTime? DocPagadoFechaEmision { get; set; }
        public string? DocPagadoNumCp { get; set; }
        public decimal? DocPagadoTotal { get; set; }
        public decimal? DocPagadoAmortizado { get; set; }
        public string? MedioPago { get; set; }
        public string? MedioPagoNumero { get; set; }
        public string? DocPagadoTipoCp { get; set; }
        public string? DocPagadoTipoCpCobrarPagar { get; set; }
        public bool? DocPagadoAnulado { get; set; }
        public string DocPagadoResponsableCodigo { get; set; } = null!;
        public string? DocPagadoResponsableNombre { get; set; }
        public string? DocPagadoModPago { get; set; }
        public string? DocPagadoPersonaCodigo { get; set; }
        public string? DocPagadoPersonaNombre { get; set; }
        public string Grupo { get; set; } = null!;
        public decimal? DetalleImportePrestamo { get; set; }
        public decimal? DetalleImporteGasto { get; set; }
        public decimal? DetalleGastoTotal { get; set; }
        public decimal? DetalleGastoAmortizado { get; set; }
    }
}

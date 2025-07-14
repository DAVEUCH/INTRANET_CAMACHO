using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class NessCuentacorrienteProveedorNew
    {
        public int Identy { get; set; }
        public string? TipoCp { get; set; }
        public int? DocumentoPagoPersonaTipoId { get; set; }
        public string? DocumentoPagoPersonaTipo { get; set; }
        public int DocumentoPagoPersonaId { get; set; }
        public string? DocumentoPagoPersonaCodigo { get; set; }
        public string? DocumentoPagoPersonaNombre { get; set; }
        public string? DocumentoPagoPersonaTipoDocumentoIdentidadCodigo { get; set; }
        public string? DocumentoPagoPersonaDocumentoIdentidad { get; set; }
        public int? DocumentoPagoCuentaId { get; set; }
        public string? DocumentoPagoCuentaNumero { get; set; }
        public string? DocumentoPagoCuentaDescripcion { get; set; }
        public int? DocumentoPagoId { get; set; }
        public DateTime DocumentoPagoFechaEmision { get; set; }
        public DateTime DocumentoPagoFecha { get; set; }
        public int DocumentoPagoTipoId { get; set; }
        public string? DocumentoPagoTipoAbreviacion { get; set; }
        public string? DocumentoPagoTipoDescripcion { get; set; }
        public string DocumentoPagoNumero { get; set; } = null!;
        public string DocumentoPagoNumeroContable { get; set; } = null!;
        public decimal? DocumentoPagoMontoSoles { get; set; }
        public decimal? DocumentoPagoMontoDolares { get; set; }
        public decimal? DocumentoPagoSaldoSoles { get; set; }
        public decimal? DocumentoPagoSaldoDolares { get; set; }
        public decimal DocumentoPagoTipoCambio { get; set; }
        public DateTime DocumentoPagoFechaTipoCambio { get; set; }
        public DateTime? DocumentoPagoFechaVencimiento { get; set; }
        public DateTime? DocumentoPagoFechaProgramcion { get; set; }
        public DateTime? DocumentoPagoFechaUltimoPago { get; set; }
        public int DocumentoPagoResponsableId { get; set; }
        public string? DocumentoPagoResponsableCodigo { get; set; }
        public string? DocumentoPagoResponsableNombre { get; set; }
        public bool? DocumentoPagoPagado { get; set; }
        public string? DocumentoPagoPorCobrarOpagar { get; set; }
        public int? DocumentoPagoMovimiento { get; set; }
        public int DocumentoPagoSucursalId { get; set; }
        public string? DocumentoPagoSucursalNombre { get; set; }
        public bool? Credito { get; set; }
        public bool? PercepcionValidar { get; set; }
        public decimal? PorcentajePercecion { get; set; }
        public decimal MontoPercepcion { get; set; }
        public decimal? DocumentoPercepcionMontoSoles { get; set; }
        public decimal? DocumentoPercepcionMontoDolares { get; set; }
        public decimal? DocumentoPercepcionSaldoSoles { get; set; }
        public decimal? DocumentoPercepcionSaldoDolares { get; set; }
        public string? DireccionProveedor { get; set; }
        public string? TelefonoProveedor { get; set; }
        public decimal? LineaUtilizadaSoles { get; set; }
        public decimal? LineaUtilizadaDolares { get; set; }
        public decimal? LineaCredito { get; set; }
        public string NumeroUnico { get; set; } = null!;
        public string BancoProveedor { get; set; } = null!;
        public string EstadoDocumento { get; set; } = null!;
        public int? DiasXvencer { get; set; }
        public string? NumCpAntecesor { get; set; }
        public bool? DireccionPrincipal { get; set; }
        public int? Distrito { get; set; }
        public int? Provincia { get; set; }
        public int? Departamento { get; set; }
    }
}

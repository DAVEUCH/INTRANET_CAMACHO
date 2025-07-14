using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptReciboCajaplanilla
    {
        public int? ComprobanteId { get; set; }
        public string? ComprobanteCptoOperacionCod { get; set; }
        public string? ComprobanteCptoOperacion { get; set; }
        public DateTime? ComprobanteFecha { get; set; }
        public string? ComprobanteTipoCpAbre { get; set; }
        public string? ComprobanteNumero { get; set; }
        public decimal? ComprobanteTotalSoles { get; set; }
        public decimal? ComprobanteTotalDolares { get; set; }
        public int? MedioPagoId { get; set; }
        public string? MedioPagoTipo { get; set; }
        public string? MedioPagoMoneda { get; set; }
        public string? MedioPagoMonedaSimbolo { get; set; }
        public string? MedioPagoNumeroDoc { get; set; }
        public string? MedioPagoCajaCod { get; set; }
        public string? MedioPagoCajaNombre { get; set; }
        public int? DocCobrarPagarId { get; set; }
        public DateTime? DocCobrarPagarFecha { get; set; }
        public string? DocCobrarPagarNumero { get; set; }
        public decimal? DocCobrarPagarPago { get; set; }
        public decimal? DocCobrarPagarSaldo { get; set; }
        public string? DocCobrarPagarOdcod { get; set; }
        public string? DocCobrarPagarOdnombre { get; set; }
        public string? DocCobrarPagarOdtipoDocId { get; set; }
        public string? DocCobrarPagarIddi { get; set; }
        public string? DocCobrarPagarMonedaNombre { get; set; }
        public string? DocCobrarPagarMonedaSimbolo { get; set; }
        public string? DocCobrarPagarTipoCp { get; set; }
        public decimal? MedioPagoTipoCambio { get; set; }
        public decimal? DocCobrarPagarTipoCambio { get; set; }
        public string? ComprobanteTotalSolesLetras { get; set; }
        public string? ComprobanteTotalDolaresLetras { get; set; }
        public string DocCobrarPagarCuenta { get; set; } = null!;
        public string DocCobrarPagarCuentaGlosa { get; set; } = null!;
        public string DocCobrarPagarCuentaDescripcion { get; set; } = null!;
        public string? MedioPagoRegistroBanco { get; set; }
        public int? MovSaldo { get; set; }
    }
}

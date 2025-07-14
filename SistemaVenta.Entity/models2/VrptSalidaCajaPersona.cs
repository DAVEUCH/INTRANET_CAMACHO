using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptSalidaCajaPersona
    {
        public int ComprobanteId { get; set; }
        public string ComprobanteCptoOperacionCod { get; set; } = null!;
        public string ComprobanteCptoOperacion { get; set; } = null!;
        public DateTime ComprobanteFecha { get; set; }
        public string ComprobanteTipoCpAbre { get; set; } = null!;
        public string ComprobanteNumero { get; set; } = null!;
        public decimal ComprobanteTotalSoles { get; set; }
        public decimal ComprobanteTotalDolares { get; set; }
        public int MedioPagoId { get; set; }
        public string MedioPagoTipo { get; set; } = null!;
        public string MedioPagoMoneda { get; set; } = null!;
        public string MedioPagoMonedaSimbolo { get; set; } = null!;
        public string MedioPagoNumeroDoc { get; set; } = null!;
        public string MedioPagoCajaCod { get; set; } = null!;
        public string MedioPagoCajaNombre { get; set; } = null!;
        public int? DocCobrarPagarId { get; set; }
        public DateTime? DocCobrarPagarFecha { get; set; }
        public string? DocCobrarPagarNumero { get; set; }
        public decimal DocCobrarPagarPago { get; set; }
        public decimal? DocCobrarPagarSaldo { get; set; }
        public string? DocCobrarPagarOdcod { get; set; }
        public string? DocCobrarPagarOdnombre { get; set; }
        public string? DocCobrarPagarOdtipoDocId { get; set; }
        public string? DocCobrarPagarOddireccion { get; set; }
        public string? DocCobrarPagarMonedaNombre { get; set; }
        public string? DocCobrarPagarMonedaSimbolo { get; set; }
        public string? DocCobrarPagarTipoCp { get; set; }
        public decimal MedioPagoTipoCambio { get; set; }
        public decimal? DocCobrarPagarTipoCambio { get; set; }
        public string? ComprobanteTotalSolesLetras { get; set; }
        public string? ComprobanteTotalDolaresLetras { get; set; }
        public string DocCobrarPagarCuenta { get; set; } = null!;
        public string DocCobrarPagarCuentaGlosa { get; set; } = null!;
        public string? DocCobrarPagarCuentaDescripcion { get; set; }
        public string? MedioPagoRegistroBanco { get; set; }
    }
}

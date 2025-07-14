using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvVentasTipoMedioPagoOld
    {
        public int? Anio { get; set; }
        public int? Mes { get; set; }
        public string? ItemPagoMonedaSimbolo { get; set; }
        public string? DocumentoCargoId { get; set; }
        public int DocumentoCargoTipoCpId { get; set; }
        public string DocumentoCargoTipoCpAbreviacion { get; set; } = null!;
        public int DocumentoCargoOrigenDestinoId { get; set; }
        public string DocumentoCargoOrigenDestinoCodigo { get; set; } = null!;
        public string DocumentoCargoOrigenDestinoNombre { get; set; } = null!;
        public string? DocumentoCargoPersonaDocIdentidad { get; set; }
        public DateTime DocumentoCargoFecha { get; set; }
        public DateTime DocumentoCargoFechaEmision { get; set; }
        public DateTime DocumentoCargoFechaVencimiento { get; set; }
        public int? DocumentoCargoSucursalId { get; set; }
        public string? DocumentoCargoSucursalNombre { get; set; }
        public string DocumentoCargoNumero { get; set; } = null!;
        public decimal DocumentoCargoSaldo { get; set; }
        public decimal? DocumentoCargoSaldoASoles { get; set; }
        public decimal? DocumentoCargoTotal { get; set; }
        public decimal? DocumentoCargoTotalASoles { get; set; }
        public bool DocumentoCargoEsCredito { get; set; }
        public int ItemPagoMedioDePagoPkid { get; set; }
        public string ItemPagoMedioDePagoCodigo { get; set; } = null!;
        public string? ItemPagoMedioDePagoDescripcion { get; set; }
        public decimal? ItemPagoTipoCambio { get; set; }
        public decimal? ItemPagoMedioDePagoTotal { get; set; }
        public decimal ItemPagoMedioDePagoTotalSol { get; set; }
        public decimal ItemPagoMedioDePagoTotalDol { get; set; }
        public decimal? ItemPagoMedioDePagoTotalASoles { get; set; }
    }
}

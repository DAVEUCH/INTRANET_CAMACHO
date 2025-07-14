using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ECargoAbono
    {
        public int Idasiento { get; set; }
        public int CargoAbonosId { get; set; }
        public int CargoAbonosIdcuentaContable { get; set; }
        public int CargoAbonosIdmoneda { get; set; }
        public decimal CargoAbonosCargo { get; set; }
        public decimal CargoAbonosAbono { get; set; }
        public decimal CargoAbonosCargoMonedaBase { get; set; }
        public decimal CargoAbonosAbonoMonedaBase { get; set; }
        public int CargoAbonosIdasientoTransferencia { get; set; }
        public bool CargoAbonosEsTransferencia { get; set; }
        public int CargoAbonosIdauxiliar { get; set; }
        public int CargoAbonosIdcentroDeCosto { get; set; }
        public decimal CargoAbonosPorcentajeTransferenciaCargo { get; set; }
        public decimal CargoAbonosPorcentajeTransferenciaAbono { get; set; }
        public bool CargoAbonosEsRedondeo { get; set; }
        public int CargoAbonosIddocCobrarPagar { get; set; }
        public int CargoAbonosIdcpCaja { get; set; }
        public string CargoAbonosGlosa { get; set; } = null!;
        public decimal CargoAbonosCargoMonedaDocumento { get; set; }
        public decimal CargoAbonosAbonoMonedaDocumento { get; set; }
        public decimal CargoAbonosTipoCambioComercial { get; set; }
        public int? DocCobrarPagarId { get; set; }
        public int? DocCobrarPagarIdcargoAbono { get; set; }
        public int? DocCobrarPagarIdcp { get; set; }
        public int? DocCobrarPagarIdcuentaContable { get; set; }
        public int? DocCobrarPagarIdauxiliar { get; set; }
        public decimal? DocCobrarPagarSaldo { get; set; }
        public decimal? DocCobrarPagarTotal { get; set; }
        public DateTime? DocCobrarPagarFechaUltimoPago { get; set; }
        public bool? DocCobrarPagarPagado { get; set; }
        public int? DocCobrarPagarIdcentroDeCosto { get; set; }
        public string? DocCobrarPagarTipoDocPago { get; set; }
        public decimal CargoAbonosCargoMonedaBase2 { get; set; }
        public decimal CargoAbonosAbonoMonedaBase2 { get; set; }
        public decimal CargoAbonosCargoPercepcion { get; set; }
        public decimal CargoAbonosAbonoPercepcion { get; set; }
    }
}

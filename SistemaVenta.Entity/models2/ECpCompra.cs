using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ECpCompra
    {
        public int Id { get; set; }
        public int IdtipoCp { get; set; }
        public int Idpersona { get; set; }
        public int Idmoneda { get; set; }
        public int IdcptoOperacion { get; set; }
        public int Idperiodo { get; set; }
        public int Idsucursal { get; set; }
        public string IdtipoPersona { get; set; } = null!;
        public string IdtipoAsociado { get; set; } = null!;
        public int Idimpuesto { get; set; }
        public int IdlibroAuxiliar { get; set; }
        public int Idresponsable { get; set; }
        public int IdmotivoAnulacion { get; set; }
        public int IdvoucherContable { get; set; }
        public bool Anulado { get; set; }
        public bool Contabilizado { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaTipoCambio { get; set; }
        public decimal TipoCambio { get; set; }
        public DateTime Hora { get; set; }
        public bool Impreso { get; set; }
        public string NumCp { get; set; } = null!;
        public string Observacion { get; set; } = null!;
        public string? PersonaNombre { get; set; }
        public string NumCpContable { get; set; } = null!;
        public bool Preliminar { get; set; }
        public bool MonedaBase { get; set; }
        public bool Tercero { get; set; }
        public string NumeroVerificacion { get; set; } = null!;
        public decimal ValorAfecto { get; set; }
        public decimal ValorInafecto { get; set; }
        public decimal ValorVenta { get; set; }
        public decimal SubTotal { get; set; }
        public decimal ValorDescuento { get; set; }
        public decimal Total { get; set; }
        public bool TieneImpuesto { get; set; }
        public bool PreciosIncImpto { get; set; }
        public bool Administrativo { get; set; }
        public string RelacionTipoCpOrigen { get; set; } = null!;
        public string RelacionBalanceOrigenA { get; set; } = null!;
        public string RelacionBalanceOrigenB { get; set; } = null!;
        public string RelacionCardinalidad { get; set; } = null!;
        public string RelacionPropiedadReferencia { get; set; } = null!;
        public string RelacionPropiedadBalance { get; set; } = null!;
        public string RelacionTipoRelacion { get; set; } = null!;
        public int Idrelacion { get; set; }
        public int CpCobrarPagarId { get; set; }
        public int? CpCobrarPagarIdmoneda { get; set; }
        public int? CpCobrarPagarIdpersona { get; set; }
        public int? CpCobrarPagarIdmodalidadCredito { get; set; }
        public int? CpCobrarPagarIdtipoMedioDePago { get; set; }
        public DateTime? CpCobrarPagarFechaVencimiento { get; set; }
        public decimal? CpCobrarPagarSaldo { get; set; }
        public string? CpCobrarPagarTipoCpCobrarPagar { get; set; }
        public decimal? CpCobrarPagarTotal { get; set; }
        public bool? CpCobrarPagarCredito { get; set; }
        public int? CpCobrarPagarIdresponsable { get; set; }
        public DateTime? CpCobrarPagarFechaProgramacionPago { get; set; }
        public int? CpCobrarPagarIdcaja { get; set; }
        public bool? CpCobrarPagarSujetoAdetraccion { get; set; }
        public decimal? CpCobrarPagarMontoDetraccion { get; set; }
        public bool? CpCobrarPagarSujetoApercepcion { get; set; }
        public decimal? CpCobrarPagarMontoPercepcion { get; set; }
        public decimal? CpCobrarPagarPorcentajePercepcion { get; set; }
        public decimal? CpCobrarPagarSaldoPercepcion { get; set; }
        public int? CpCobrarPagarMovSaldo { get; set; }
        public int CpCompraIdcpInventario { get; set; }
        public string CpCompraDocIdentidad { get; set; } = null!;
        public string CpCompraEstadoEntrega { get; set; } = null!;
        public string CpCompraEstadoDevolucion { get; set; } = null!;
        public string CpCompraEstadoEntregaDevolucion { get; set; } = null!;
        public string CpCompraEstadoDescuento { get; set; } = null!;
        public decimal CpCompraBalanceNotaCredito { get; set; }
        public bool CpCompraImportacion { get; set; }
        public int CpCompraIdincoterm { get; set; }
        public int CpCompraTipoItem { get; set; }
        public int CpCompraCpInventarioId { get; set; }
        public int CpCompraCpInventarioIdalmacen { get; set; }
        public int CpCompraCpInventarioIdtipoOperacion { get; set; }
        public int CpCompraCpInventarioMovStockContable { get; set; }
        public int CpCompraCpInventarioMovStockFisico { get; set; }
        public int CpCompraCpInventarioMovStockPorEntregar { get; set; }
        public int CpCompraCpInventarioMovStockPorRecibir { get; set; }
        public string CpCompraCpInventarioTipoCpInventario { get; set; } = null!;
        public decimal CpCompraCpInventarioPeso { get; set; }
        public decimal CpCompraCpInventarioVolumen { get; set; }
        public bool CpCompraCpInventarioSobregirarStockDisponible { get; set; }
        public bool? CpCompraCpInventarioCostoPromedio { get; set; }
        public int? CpCompraCpInventarioCostoPromedioCantidad { get; set; }
        public int? CpCompraCpInventarioCostoPromedioMonto { get; set; }
        public bool? CpCompraCpInventarioCostoUltimaCompra { get; set; }
        public bool? CpCompraCpInventarioCostoReferencia { get; set; }
        public bool? CpCompraCpInventarioCostoParalelo { get; set; }
        public bool? CpCompraCpInventarioSugerenciaCompra { get; set; }
        public bool Revisado { get; set; }
        public string? CpCobrarPagarNumeroDetraccion { get; set; }
        public DateTime? CpCobrarPagarFechaDetraccion { get; set; }
        public decimal AjusteImpuesto { get; set; }
        public string CpCompraNumeroReferencia { get; set; } = null!;
        public DateTime? CpCobrarPagarFechaPago { get; set; }
        public string NumCpReferenciado { get; set; } = null!;
        public bool EvaluarPercepcion { get; set; }
        public bool EvaluarDetraccion { get; set; }
        public bool SumarPercepcionAlTotal { get; set; }
        public decimal MontoPercepcion { get; set; }
        public decimal MontoDetraccion { get; set; }
    }
}

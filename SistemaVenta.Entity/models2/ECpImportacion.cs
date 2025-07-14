using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ECpImportacion
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
        public int CpImportacionIdcpInventarioEntrada { get; set; }
        public int CpImportacionIdcpInventarioSalida { get; set; }
        public int CpImportacionCpInventarioSalidaId { get; set; }
        public int CpImportacionCpInventarioSalidaIdcp { get; set; }
        public int CpImportacionCpInventarioSalidaIdalmacen { get; set; }
        public int CpImportacionCpInventarioSalidaMovStockContable { get; set; }
        public int CpImportacionCpInventarioSalidaMovStockFisico { get; set; }
        public int CpImportacionCpInventarioSalidaMovStockPorEntregar { get; set; }
        public int CpImportacionCpInventarioSalidaMovStockPorRecibir { get; set; }
        public bool CpImportacionCpInventarioSalidaCostoPromedio { get; set; }
        public int CpImportacionCpInventarioSalidaCostoPromedioCantidad { get; set; }
        public int CpImportacionCpInventarioSalidaCostoPromedioMonto { get; set; }
        public bool CpImportacionCpInventarioSalidaCostoUltimaCompra { get; set; }
        public bool CpImportacionCpInventarioSalidaCostoReferencia { get; set; }
        public bool CpImportacionCpInventarioSalidaCostoParalelo { get; set; }
        public string CpImportacionCpInventarioSalidaTipoCpInventario { get; set; } = null!;
        public decimal CpImportacionCpInventarioSalidaPeso { get; set; }
        public decimal CpImportacionCpInventarioSalidaVolumen { get; set; }
        public bool CpImportacionCpInventarioSalidaSobregirarStockDisponible { get; set; }
        public bool CpImportacionCpInventarioSalidaSugerenciaCompra { get; set; }
        public int CpImportacionCpInventarioEntradaId { get; set; }
        public int CpImportacionCpInventarioEntradaIdcp { get; set; }
        public int CpImportacionCpInventarioEntradaIdalmacen { get; set; }
        public int CpImportacionCpInventarioEntradaMovStockContable { get; set; }
        public int CpImportacionCpInventarioEntradaMovStockFisico { get; set; }
        public int CpImportacionCpInventarioEntradaMovStockPorEntregar { get; set; }
        public int CpImportacionCpInventarioEntradaMovStockPorRecibir { get; set; }
        public bool CpImportacionCpInventarioEntradaCostoPromedio { get; set; }
        public int CpImportacionCpInventarioEntradaCostoPromedioCantidad { get; set; }
        public int CpImportacionCpInventarioEntradaCostoPromedioMonto { get; set; }
        public bool CpImportacionCpInventarioEntradaCostoUltimaCompra { get; set; }
        public bool CpImportacionCpInventarioEntradaCostoReferencia { get; set; }
        public bool CpImportacionCpInventarioEntradaCostoParalelo { get; set; }
        public string CpImportacionCpInventarioEntradaTipoCpInventario { get; set; } = null!;
        public decimal CpImportacionCpInventarioEntradaPeso { get; set; }
        public decimal CpImportacionCpInventarioEntradaVolumen { get; set; }
        public bool CpImportacionCpInventarioEntradaSobregirarStockDisponible { get; set; }
        public bool CpImportacionCpInventarioEntradaSugerenciaCompra { get; set; }
        public int CpImportacionCpInventarioEntradaIdtipoOperacion { get; set; }
        public int CpImportacionCpInventarioSalidaIdtipoOperacion { get; set; }
        public DateTime FechaTipoCambio { get; set; }
        public decimal TipoCambio { get; set; }
        public bool Revisado { get; set; }
        public string? CpCobrarPagarNumeroDetraccion { get; set; }
        public DateTime? CpCobrarPagarFechaDetraccion { get; set; }
        public decimal AjusteImpuesto { get; set; }
        public DateTime? CpCobrarPagarFechaPago { get; set; }
        public string NumCpReferenciado { get; set; } = null!;
        public bool EvaluarPercepcion { get; set; }
        public bool EvaluarDetraccion { get; set; }
        public bool SumarPercepcionAlTotal { get; set; }
        public decimal MontoPercepcion { get; set; }
        public decimal MontoDetraccion { get; set; }
    }
}

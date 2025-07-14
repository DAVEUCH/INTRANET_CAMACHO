using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ECpVentum
    {
        public int Id { get; set; }
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
        public decimal Total { get; set; }
        public int IdtipoCp { get; set; }
        public int Idpersona { get; set; }
        public int Idmoneda { get; set; }
        public int IdcptoOperacion { get; set; }
        public int Idperiodo { get; set; }
        public int Idsucursal { get; set; }
        public int IdvoucherContable { get; set; }
        public string IdtipoPersona { get; set; } = null!;
        public int Idrelacion { get; set; }
        public string? RelacionTipoCpOrigen { get; set; }
        public string? RelacionBalanceOrigenA { get; set; }
        public string? RelacionBalanceOrigenB { get; set; }
        public string? RelacionCardinalidad { get; set; }
        public string? RelacionPropiedadReferencia { get; set; }
        public string? RelacionPropiedadBalance { get; set; }
        public string? RelacionTipoRelacion { get; set; }
        public int CpVentaPkid { get; set; }
        public int CpVentaIdcpInventario { get; set; }
        public string CpVentaDocIdentidad { get; set; } = null!;
        public string CpVentaEstadoEntrega { get; set; } = null!;
        public bool CpVentaClienteDescriptivo { get; set; }
        public string CpVentaDireccion { get; set; } = null!;
        public string CpVentaEstadoDevolucion { get; set; } = null!;
        public string CpVentaEstadoEntregaDevolucion { get; set; } = null!;
        public string CpVentaEstadoDescuento { get; set; } = null!;
        public int CpCobrarPagarId { get; set; }
        public int CpCobrarPagarIdmoneda { get; set; }
        public int CpCobrarPagarIdpersona { get; set; }
        public int CpCobrarPagarIdmodalidadCredito { get; set; }
        public int CpCobrarPagarIdtipoMedioDePago { get; set; }
        public string CpCobrarPagarTipoCpCobrarPagar { get; set; } = null!;
        public bool CpCobrarPagarCredito { get; set; }
        public DateTime CpCobrarPagarFechaVencimiento { get; set; }
        public decimal CpCobrarPagarSaldo { get; set; }
        public decimal CpCobrarPagarTotal { get; set; }
        public int CpCobrarPagarIdresponsable { get; set; }
        public int CpCobrarPagarIdcaja { get; set; }
        public DateTime CpCobrarPagarFechaProgramacionPago { get; set; }
        public int? CpVentaCpInventarioId { get; set; }
        public int? CpVentaCpInventarioIdalmacen { get; set; }
        public int? CpVentaCpInventarioMovStockContable { get; set; }
        public int? CpVentaCpInventarioMovStockFisico { get; set; }
        public int? CpVentaCpInventarioMovStockPorEntregar { get; set; }
        public int? CpVentaCpInventarioMovStockPorRecibir { get; set; }
        public string? CpVentaCpInventarioTipoCpInventario { get; set; }
        public decimal? CpVentaCpInventarioPeso { get; set; }
        public decimal? CpVentaCpInventarioVolumen { get; set; }
        public bool? CpVentaCpInventarioSobregirarStockDisponible { get; set; }
        public string CpVentaDireccionEntrega { get; set; } = null!;
        public bool CpVentaVentaEspecial { get; set; }
        public bool CpVentaEscalaPreferencial { get; set; }
        public string CpVentaNumeroOrdenCompra { get; set; } = null!;
        public string NumCpContable { get; set; } = null!;
        public int IdmotivoAnulacion { get; set; }
        public int CpVentaCpDistribucionPkid { get; set; }
        public int? CpVentaCpDistribucionIdfuerzaVentas { get; set; }
        public int? CpVentaCpDistribucionIdzonaVenta { get; set; }
        public int? CpVentaCpDistribucionIdzonaReparto { get; set; }
        public bool? CpVentaCpDistribucionFueraDeRuta { get; set; }
        public int? CpVentaCpDistribucionIdgrupoVentas { get; set; }
        public bool? CpVentaCpInventarioCostoPromedio { get; set; }
        public int? CpVentaCpInventarioCostoPromedioCantidad { get; set; }
        public int? CpVentaCpInventarioCostoPromedioMonto { get; set; }
        public bool? CpVentaCpInventarioCostoUltimaCompra { get; set; }
        public bool? CpVentaCpInventarioCostoReferencia { get; set; }
        public bool? CpVentaCpInventarioCostoParalelo { get; set; }
        public int? CpVentaCpInventarioIdtipoOperacion { get; set; }
        public bool Preliminar { get; set; }
        public decimal CpVentaEfectivoRestringido { get; set; }
        public bool CpCobrarPagarSujetoAdetraccion { get; set; }
        public bool CpCobrarPagarSujetoApercepcion { get; set; }
        public decimal CpCobrarPagarMontoDetraccion { get; set; }
        public bool MonedaBase { get; set; }
        public bool CpVentaAplicaDistribucion { get; set; }
        public bool Tercero { get; set; }
        public string NumeroVerificacion { get; set; } = null!;
        public decimal CpCobrarPagarMontoPercepcion { get; set; }
        public decimal CpCobrarPagarPorcentajePercepcion { get; set; }
        public decimal CpCobrarPagarSaldoPercepcion { get; set; }
        public int CpCobrarPagarMovSaldo { get; set; }
        public int Idimpuesto { get; set; }
        public int IdlibroAuxiliar { get; set; }
        public int Idresponsable { get; set; }
        public decimal ValorAfecto { get; set; }
        public decimal ValorInafecto { get; set; }
        public decimal ValorVenta { get; set; }
        public decimal SubTotal { get; set; }
        public decimal ValorDescuento { get; set; }
        public bool TieneImpuesto { get; set; }
        public bool PreciosIncImpto { get; set; }
        public bool Administrativo { get; set; }
        public string IdtipoAsociado { get; set; } = null!;
        public bool CpVentaOmitirPoliticasCredito { get; set; }
        public bool? CpVentaCpInventarioSugerenciaCompra { get; set; }
        public bool Revisado { get; set; }
        public int CpVentaIdcliente2 { get; set; }
        public string? CpCobrarPagarNumeroDetraccion { get; set; }
        public DateTime? CpCobrarPagarFechaDetraccion { get; set; }
        public decimal AjusteImpuesto { get; set; }
        public DateTime CpCobrarPagarFechaPago { get; set; }
        public string NumCpReferenciado { get; set; } = null!;
        public bool EvaluarPercepcion { get; set; }
        public bool EvaluarDetraccion { get; set; }
        public bool SumarPercepcionAlTotal { get; set; }
        public decimal MontoPercepcion { get; set; }
        public decimal MontoDetraccion { get; set; }
    }
}

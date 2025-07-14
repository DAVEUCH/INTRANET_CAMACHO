using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EPedidoFreddy
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
        public int PedidoPkid { get; set; }
        public int PedidoIdcpInventario { get; set; }
        public int PedidoIdtipoMedioDePago { get; set; }
        public int PedidoIdmodalidadCredito { get; set; }
        public string PedidoEstadoFacturacion { get; set; } = null!;
        public string PedidoEstadoAprobacion { get; set; } = null!;
        public bool PedidoSaldoCancelado { get; set; }
        public DateTime PedidoFechaPago { get; set; }
        public bool PedidoCancelado { get; set; }
        public string PedidoDocIdentidad { get; set; } = null!;
        public string PedidoEstadoEntrega { get; set; } = null!;
        public bool PedidoCredito { get; set; }
        public bool PedidoClienteDescriptivo { get; set; }
        public string PedidoDireccion { get; set; } = null!;
        public int? PedidoCpInventarioId { get; set; }
        public int? PedidoCpInventarioIdalmacen { get; set; }
        public int? PedidoCpInventarioMovStockContable { get; set; }
        public int? PedidoCpInventarioMovStockFisico { get; set; }
        public int? PedidoCpInventarioMovStockPorEntregar { get; set; }
        public int? PedidoCpInventarioMovStockPorRecibir { get; set; }
        public string? PedidoCpInventarioTipoCpInventario { get; set; }
        public decimal? PedidoCpInventarioPeso { get; set; }
        public decimal? PedidoCpInventarioVolumen { get; set; }
        public bool? PedidoCpInventarioSobregirarStockDisponible { get; set; }
        public decimal PedidoMontoDctoPromocional { get; set; }
        public string PedidoDireccionEntrega { get; set; } = null!;
        public bool PedidoVentaEspecial { get; set; }
        public bool PedidoEscalaPreferencial { get; set; }
        public string PedidoNumeroOrdenCompra { get; set; } = null!;
        public bool PedidoPagoEfectivo { get; set; }
        public int PedidoCpDistribucionPkid { get; set; }
        public int? PedidoCpDistribucionIdfuerzaVentas { get; set; }
        public int? PedidoCpDistribucionIdzonaVenta { get; set; }
        public int? PedidoCpDistribucionIdzonaReparto { get; set; }
        public bool? PedidoCpDistribucionFueraDeRuta { get; set; }
        public int? PedidoCpDistribucionIdgrupoVentas { get; set; }
        public bool? PedidoCpInventarioCostoPromedio { get; set; }
        public int? PedidoCpInventarioCostoPromedioCantidad { get; set; }
        public int? PedidoCpInventarioCostoPromedioMonto { get; set; }
        public bool? PedidoCpInventarioCostoUltimaCompra { get; set; }
        public bool? PedidoCpInventarioCostoReferencia { get; set; }
        public bool? PedidoCpInventarioCostoParalelo { get; set; }
        public int? PedidoCpInventarioIdtipoOperacion { get; set; }
        public bool PedidoRequiereAprobacion { get; set; }
        public decimal PedidoEfectivoRestringido { get; set; }
        public bool PedidoAplicaDistribucion { get; set; }
        public bool PedidoOmitirPoliticasCredito { get; set; }
        public DateTime PedidoFechaEntrega { get; set; }
        public bool PedidoAjustado { get; set; }
        public bool? PedidoCpInventarioSugerenciaCompra { get; set; }
        public bool Revisado { get; set; }
        public int PedidoIdcliente2 { get; set; }
        public DateTime? PedidoFechaAprobacion { get; set; }
        public decimal AjusteImpuesto { get; set; }
        public string NumCpReferenciado { get; set; } = null!;
        public DateTime? CpCobrarPagarFechaPago { get; set; }
        public int PedidoIdgrupoVentas { get; set; }
        public int IdgrupoVentas { get; set; }
        public decimal? PedidoFreddyPedidoFreddyPorcentajeComisionExterna { get; set; }
        public int? PedidoFreddyPedidoFreddyIdempresaTransporte { get; set; }
        public bool SumarPercepcionAlTotal { get; set; }
        public bool EvaluarDetraccion { get; set; }
        public bool EvaluarPercepcion { get; set; }
        public decimal MontoPercepcion { get; set; }
        public decimal MontoDetraccion { get; set; }
    }
}

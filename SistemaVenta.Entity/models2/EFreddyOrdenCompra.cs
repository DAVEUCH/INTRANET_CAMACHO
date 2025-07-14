using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EFreddyOrdenCompra
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
        public decimal? CpCobrarPagarMontoPercepcion { get; set; }
        public decimal? CpCobrarPagarPorcentajePercepcion { get; set; }
        public decimal? CpCobrarPagarSaldoPercepcion { get; set; }
        public int OrdenCompraIdcpInventario { get; set; }
        public int OrdenCompraIdmodalidadCredito { get; set; }
        public string OrdenCompraEstadoFacturacion { get; set; } = null!;
        public string OrdenCompraEstadoAprobacion { get; set; } = null!;
        public bool OrdenCompraSaldoCancelado { get; set; }
        public DateTime OrdenCompraFechaPago { get; set; }
        public decimal OrdenCompraMontoDctoPromocional { get; set; }
        public bool OrdenCompraCancelado { get; set; }
        public string OrdenCompraDocIdentidad { get; set; } = null!;
        public string OrdenCompraEstadoEntrega { get; set; } = null!;
        public bool OrdenCompraCredito { get; set; }
        public bool OrdenCompraClienteDescriptivo { get; set; }
        public string OrdenCompraDireccion { get; set; } = null!;
        public string OrdenCompraIdconsolidadoOc { get; set; } = null!;
        public string OrdenCompraDireccionEntrega { get; set; } = null!;
        public bool OrdenCompraConsignacion { get; set; }
        public bool OrdenCompraConsolidado { get; set; }
        public string OrdenCompraFormaGeneracion { get; set; } = null!;
        public bool OrdenCompraRequiereAprobacion { get; set; }
        public bool OrdenCompraImportacion { get; set; }
        public int OrdenCompraIdincoterm { get; set; }
        public int OrdenCompraCpInventarioId { get; set; }
        public int OrdenCompraCpInventarioIdalmacen { get; set; }
        public int OrdenCompraCpInventarioMovStockContable { get; set; }
        public int OrdenCompraCpInventarioMovStockFisico { get; set; }
        public int OrdenCompraCpInventarioMovStockPorEntregar { get; set; }
        public int OrdenCompraCpInventarioMovStockPorRecibir { get; set; }
        public string OrdenCompraCpInventarioTipoCpInventario { get; set; } = null!;
        public decimal? OrdenCompraCpInventarioPeso { get; set; }
        public decimal? OrdenCompraCpInventarioVolumen { get; set; }
        public bool? OrdenCompraCpInventarioSobregirarStockDisponible { get; set; }
        public bool? OrdenCompraCpInventarioCostoPromedio { get; set; }
        public int? OrdenCompraCpInventarioCostoPromedioCantidad { get; set; }
        public int? OrdenCompraCpInventarioCostoPromedioMonto { get; set; }
        public bool? OrdenCompraCpInventarioCostoUltimaCompra { get; set; }
        public bool? OrdenCompraCpInventarioCostoReferencia { get; set; }
        public bool? OrdenCompraCpInventarioCostoParalelo { get; set; }
        public int? OrdenCompraCpInventarioIdtipoOperacion { get; set; }
        public DateTime OrdenCompraFechaEntrega { get; set; }
        public bool? OrdenCompraCpInventarioSugerenciaCompra { get; set; }
        public bool Revisado { get; set; }
        public DateTime? FechaAprobacion { get; set; }
        public decimal AjusteImpuesto { get; set; }
        public string NumCpReferenciado { get; set; } = null!;
        public DateTime? CpCobrarPagarFechaPago { get; set; }
        public int OrdenCompraPkid { get; set; }
        public DateTime? OrdenCompraFreddyOrdenCompraFechaEmbarque { get; set; }
        public DateTime? OrdenCompraFreddyOrdenCompraFechaLlegada { get; set; }
        public string? OrdenCompraFreddyOrdenCompraIngresoCarga { get; set; }
        public bool? CpCobrarPagarSujetoApercepcion { get; set; }
        public bool SumarPercepcionAlTotal { get; set; }
        public decimal MontoDetraccion { get; set; }
        public decimal MontoPercepcion { get; set; }
        public bool EvaluarDetraccion { get; set; }
        public bool EvaluarPercepcion { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ECp
    {
        public int Id { get; set; }
        public int IdtipoCp { get; set; }
        public int Idpersona { get; set; }
        public int Idmoneda { get; set; }
        public int IdcptoOperacion { get; set; }
        public int Idperiodo { get; set; }
        public int Idsucursal { get; set; }
        public string IdtipoPersona { get; set; } = null!;
        public int IdmotivoAnulacion { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaTipoCambio { get; set; }
        public decimal TipoCambio { get; set; }
        public DateTime Hora { get; set; }
        public bool Impreso { get; set; }
        public string NumCp { get; set; } = null!;
        public string NumCpContable { get; set; } = null!;
        public string Observacion { get; set; } = null!;
        public string? PersonaNombre { get; set; }
        public decimal Total { get; set; }
        public bool Anulado { get; set; }
        public bool Contabilizado { get; set; }
        public int IdvoucherContable { get; set; }
        public bool Preliminar { get; set; }
        public bool MonedaBase { get; set; }
        public bool Tercero { get; set; }
        public string NumeroVerificacion { get; set; } = null!;
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
        public bool Revisado { get; set; }
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
        public int Idrelacion { get; set; }
        public string RelacionTipoCpOrigen { get; set; } = null!;
        public string RelacionBalanceOrigenA { get; set; } = null!;
        public string RelacionBalanceOrigenB { get; set; } = null!;
        public string RelacionCardinalidad { get; set; } = null!;
        public string RelacionPropiedadReferencia { get; set; } = null!;
        public string RelacionPropiedadBalance { get; set; } = null!;
        public string RelacionTipoRelacion { get; set; } = null!;
        public int CpsId { get; set; }
        public int CpsIdtipoCp { get; set; }
        public int CpsIdpersona { get; set; }
        public int CpsIdmoneda { get; set; }
        public int CpsIdcptoOperacion { get; set; }
        public int CpsIdperiodo { get; set; }
        public int CpsIdsucursal { get; set; }
        public string CpsIdtipoPersona { get; set; } = null!;
        public string CpsIdtipoAsociado { get; set; } = null!;
        public int CpsIdmotivoAnulacion { get; set; }
        public int CpsIdvoucherContable { get; set; }
        public int CpsIdimpuesto { get; set; }
        public int CpsIdlibroAuxiliar { get; set; }
        public int CpsIdresponsable { get; set; }
        public bool CpsAnulado { get; set; }
        public bool CpsContabilizado { get; set; }
        public DateTime CpsFecha { get; set; }
        public DateTime CpsFechaEmision { get; set; }
        public DateTime CpsFechaTipoCambio { get; set; }
        public decimal CpsTipoCambio { get; set; }
        public DateTime CpsHora { get; set; }
        public bool CpsImpreso { get; set; }
        public string CpsNumCp { get; set; } = null!;
        public string CpsObservacion { get; set; } = null!;
        public string? CpsPersonaNombre { get; set; }
        public decimal CpsTotal { get; set; }
        public string CpsNumCpContable { get; set; } = null!;
        public bool CpsPreliminar { get; set; }
        public bool CpsMonedaBase { get; set; }
        public bool CpsTercero { get; set; }
        public string CpsNumeroVerificacion { get; set; } = null!;
        public decimal CpsValorAfecto { get; set; }
        public decimal CpsValorInafecto { get; set; }
        public decimal CpsValorVenta { get; set; }
        public decimal CpsSubTotal { get; set; }
        public decimal CpsValorDescuento { get; set; }
        public bool CpsTieneImpuesto { get; set; }
        public bool CpsPreciosIncImpto { get; set; }
        public bool CpsAdministrativo { get; set; }
        public bool CpsRevisado { get; set; }
        public int CpsCpCobrarPagarId { get; set; }
        public int? CpsCpCobrarPagarIdmoneda { get; set; }
        public int? CpsCpCobrarPagarIdpersona { get; set; }
        public int? CpsCpCobrarPagarIdmodalidadCredito { get; set; }
        public int? CpsCpCobrarPagarIdtipoMedioDePago { get; set; }
        public DateTime? CpsCpCobrarPagarFechaVencimiento { get; set; }
        public decimal? CpsCpCobrarPagarSaldo { get; set; }
        public string? CpsCpCobrarPagarTipoCpCobrarPagar { get; set; }
        public decimal? CpsCpCobrarPagarTotal { get; set; }
        public bool? CpsCpCobrarPagarCredito { get; set; }
        public int? CpsCpCobrarPagarIdresponsable { get; set; }
        public DateTime? CpsCpCobrarPagarFechaProgramacionPago { get; set; }
        public int? CpsCpCobrarPagarIdcaja { get; set; }
        public bool? CpsCpCobrarPagarSujetoAdetraccion { get; set; }
        public decimal? CpsCpCobrarPagarMontoDetraccion { get; set; }
        public bool? CpsCpCobrarPagarSujetoApercepcion { get; set; }
        public decimal? CpsCpCobrarPagarMontoPercepcion { get; set; }
        public decimal? CpsCpCobrarPagarPorcentajePercepcion { get; set; }
        public decimal? CpsCpCobrarPagarSaldoPercepcion { get; set; }
        public int? CpsCpCobrarPagarMovSaldo { get; set; }
        public int CpsIdrelacion { get; set; }
        public string? CpCobrarPagarNumeroDetraccion { get; set; }
        public DateTime? CpCobrarPagarFechaDetraccion { get; set; }
        public decimal AjusteImpuesto { get; set; }
        public decimal CpsAjusteImpuesto { get; set; }
        public DateTime? CpCobrarPagarFechaPago { get; set; }
        public string NumCpReferenciado { get; set; } = null!;
        public string CpsNumCpReferenciado { get; set; } = null!;
        public bool EvaluarPercepcion { get; set; }
        public bool EvaluarDetraccion { get; set; }
        public bool SumarPercepcionAlTotal { get; set; }
        public decimal MontoPercepcion { get; set; }
        public decimal MontoDetraccion { get; set; }
        public bool CpsSumarPercepcionAlTotal { get; set; }
        public decimal CpsMontoPercepcion { get; set; }
        public bool CpsEvaluarPercepcion { get; set; }
        public bool CpsEvaluarDetraccion { get; set; }
        public decimal CpsMontoDetraccion { get; set; }
    }
}

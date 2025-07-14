using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EItemCanjeLetra
    {
        public int CanjeLetrasLetrasId { get; set; }
        public int CanjeLetrasIdcanjeLetras { get; set; }
        public int CanjeLetrasLetrasIdletra { get; set; }
        public int CanjeLetrasLetrasDias { get; set; }
        public decimal CanjeLetrasLetrasPorcentaje { get; set; }
        public decimal CanjeLetrasLetrasMontoTotal { get; set; }
        public int Idletra { get; set; }
        public int Id { get; set; }
        public int CpLetraIdtipoCp { get; set; }
        public int CpLetraIdpersona { get; set; }
        public int CpLetraIdmoneda { get; set; }
        public int CpLetraIdcptoOperacion { get; set; }
        public int CpLetraIdperiodo { get; set; }
        public int CpLetraIdsucursal { get; set; }
        public string CpLetraIdtipoPersona { get; set; } = null!;
        public string CpLetraIdtipoAsociado { get; set; } = null!;
        public int CpLetraIdlibroAuxiliar { get; set; }
        public int CpLetraIdresponsable { get; set; }
        public int CpLetraIdmotivoAnulacion { get; set; }
        public int CpLetraIdvoucherContable { get; set; }
        public bool CpLetraAnulado { get; set; }
        public bool CpLetraContabilizado { get; set; }
        public DateTime CpLetraFecha { get; set; }
        public DateTime CpLetraFechaEmision { get; set; }
        public DateTime CpLetraFechaTipoCambio { get; set; }
        public decimal CpLetraTipoCambio { get; set; }
        public DateTime CpLetraHora { get; set; }
        public bool CpLetraImpreso { get; set; }
        public string CpLetraNumCp { get; set; } = null!;
        public string CpLetraObservacion { get; set; } = null!;
        public string? CpLetraPersonaNombre { get; set; }
        public string CpLetraNumCpContable { get; set; } = null!;
        public bool CpLetraPreliminar { get; set; }
        public bool CpLetraMonedaBase { get; set; }
        public bool CpLetraTercero { get; set; }
        public string CpLetraNumeroVerificacion { get; set; } = null!;
        public decimal CpLetraValorAfecto { get; set; }
        public decimal CpLetraValorInafecto { get; set; }
        public decimal CpLetraValorVenta { get; set; }
        public decimal CpLetraSubTotal { get; set; }
        public decimal CpLetraValorDescuento { get; set; }
        public decimal CpLetraTotal { get; set; }
        public bool CpLetraTieneImpuesto { get; set; }
        public bool CpLetraPreciosIncImpto { get; set; }
        public bool CpLetraAdministrativo { get; set; }
        public string CpLetraLetraDireccion { get; set; } = null!;
        public bool CpLetraLetraEnBanco { get; set; }
        public string CpLetraLetraNumeroUnicoBanco { get; set; } = null!;
        public int? CpLetraCpCobrarPagarIdmoneda { get; set; }
        public int? CpLetraCpCobrarPagarIdpersona { get; set; }
        public int? CpLetraCpCobrarPagarIdmodalidadCredito { get; set; }
        public int? CpLetraCpCobrarPagarIdtipoMedioDePago { get; set; }
        public DateTime? CpLetraCpCobrarPagarFechaVencimiento { get; set; }
        public decimal? CpLetraCpCobrarPagarSaldo { get; set; }
        public string? CpLetraCpCobrarPagarTipoCpCobrarPagar { get; set; }
        public decimal? CpLetraCpCobrarPagarTotal { get; set; }
        public bool? CpLetraCpCobrarPagarCredito { get; set; }
        public int? CpLetraCpCobrarPagarIdresponsable { get; set; }
        public DateTime? CpLetraCpCobrarPagarFechaProgramacionPago { get; set; }
        public int? CpLetraCpCobrarPagarIdcaja { get; set; }
        public bool? CpLetraCpCobrarPagarSujetoAdetraccion { get; set; }
        public decimal? CpLetraCpCobrarPagarMontoDetraccion { get; set; }
        public decimal? CpLetraCpCobrarPagarMontoPercepcion { get; set; }
        public decimal? CpLetraCpCobrarPagarPorcentajePercepcion { get; set; }
        public decimal? CpLetraCpCobrarPagarSaldoPercepcion { get; set; }
        public int? CpLetraCpCobrarPagarMovSaldo { get; set; }
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
        public int? CpCobrarPagarMovSaldo { get; set; }
        public int CpLetraId { get; set; }
        public string CpLetraRelacionTipoCpOrigen { get; set; } = null!;
        public string CpLetraRelacionBalanceOrigenA { get; set; } = null!;
        public string CpLetraRelacionBalanceOrigenB { get; set; } = null!;
        public string CpLetraRelacionCardinalidad { get; set; } = null!;
        public string CpLetraRelacionPropiedadReferencia { get; set; } = null!;
        public string CpLetraRelacionPropiedadBalance { get; set; } = null!;
        public string CpLetraRelacionTipoRelacion { get; set; } = null!;
        public int CpLetraIdrelacion { get; set; }
        public int CpLetraCpCobrarPagarId { get; set; }
        public int CpLetraIdimpuesto { get; set; }
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
        public bool CpLetraRevisado { get; set; }
        public bool Revisado { get; set; }
        public int CpLetraLetraIdestado { get; set; }
        public decimal CpLetraAjusteImpuesto { get; set; }
        public DateTime? CpCobrarPagarFechaDetraccion { get; set; }
        public string? CpCobrarPagarNumeroDetraccion { get; set; }
        public DateTime? CpCobrarPagarFechaPago { get; set; }
        public string CpLetraNumCpReferenciado { get; set; } = null!;
        public bool CpLetraEvaluarPercepcion { get; set; }
        public bool CpLetraEvaluarDetraccion { get; set; }
        public bool CpLetraSumarPercepcionAlTotal { get; set; }
        public decimal CpLetraMontoPercepcion { get; set; }
        public decimal CpLetraMontoDetraccion { get; set; }
        public bool? CpLetraCpCobrarPagarSujetoApercepcion { get; set; }
        public bool EvaluarPercepcion { get; set; }
        public bool EvaluarDetraccion { get; set; }
        public bool SumarPercepcionAlTotal { get; set; }
        public decimal MontoPercepcion { get; set; }
        public decimal MontoDetraccion { get; set; }
        public bool? CpCobrarPagarSujetoApercepcion { get; set; }
        public int CpLetraLetraIdbanco { get; set; }
        public int Idcp { get; set; }
    }
}

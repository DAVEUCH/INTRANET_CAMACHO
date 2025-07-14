using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EDocCobrarPagarCp
    {
        public int Id { get; set; }
        public int IdcargoAbono { get; set; }
        public int Idcp { get; set; }
        public int IdcuentaContable { get; set; }
        public DateTime FechaUltimoPago { get; set; }
        public decimal Saldo { get; set; }
        public decimal Total { get; set; }
        public bool Pagado { get; set; }
        public int Idauxiliar { get; set; }
        public int CpId { get; set; }
        public int CpIdtipoCp { get; set; }
        public int CpIdpersona { get; set; }
        public int CpIdmoneda { get; set; }
        public int CpIdcptoOperacion { get; set; }
        public int CpIdperiodo { get; set; }
        public int CpIdsucursal { get; set; }
        public string CpIdtipoPersona { get; set; } = null!;
        public bool CpAnulado { get; set; }
        public bool CpContabilizado { get; set; }
        public DateTime CpFecha { get; set; }
        public DateTime CpFechaEmision { get; set; }
        public DateTime CpFechaTipoCambio { get; set; }
        public decimal CpTipoCambio { get; set; }
        public DateTime CpHora { get; set; }
        public bool CpImpreso { get; set; }
        public string CpNumCp { get; set; } = null!;
        public string CpObservacion { get; set; } = null!;
        public string? CpPersonaNombre { get; set; }
        public decimal CpTotal { get; set; }
        public string CpNumCpContable { get; set; } = null!;
        public int CpIdmotivoAnulacion { get; set; }
        public int CpIdvoucherContable { get; set; }
        public int CpIdimpuesto { get; set; }
        public int CpIdlibroAuxiliar { get; set; }
        public int CpIdresponsable { get; set; }
        public string CpIdtipoAsociado { get; set; } = null!;
        public bool CpPreliminar { get; set; }
        public bool CpMonedaBase { get; set; }
        public bool CpTercero { get; set; }
        public string CpNumeroVerificacion { get; set; } = null!;
        public decimal CpValorAfecto { get; set; }
        public decimal CpValorInafecto { get; set; }
        public decimal CpValorVenta { get; set; }
        public decimal CpSubTotal { get; set; }
        public decimal CpValorDescuento { get; set; }
        public bool CpTieneImpuesto { get; set; }
        public bool CpPreciosIncImpto { get; set; }
        public bool CpAdministrativo { get; set; }
        public bool CpRevisado { get; set; }
        public int CpCpCobrarPagarId { get; set; }
        public int CpCobrarPagarIdmoneda { get; set; }
        public int CpCobrarPagarIdpersona { get; set; }
        public int CpCobrarPagarIdmodalidadCredito { get; set; }
        public int CpCobrarPagarIdtipoMedioDePago { get; set; }
        public bool CpCobrarPagarCredito { get; set; }
        public DateTime CpCobrarPagarFechaVencimiento { get; set; }
        public decimal CpCobrarPagarSaldo { get; set; }
        public string CpCobrarPagarTipoCpCobrarPagar { get; set; } = null!;
        public int CpCobrarPagarMovSaldo { get; set; }
        public decimal CpCobrarPagarTotal { get; set; }
        public int CpCobrarPagarIdresponsable { get; set; }
        public DateTime CpCobrarPagarFechaProgramacionPago { get; set; }
        public int CpCobrarPagarIdcaja { get; set; }
        public decimal CpCobrarPagarMontoDetraccion { get; set; }
        public bool CpCobrarPagarSujetoApercepcion { get; set; }
        public decimal CpCobrarPagarPorcentajePercepcion { get; set; }
        public bool CpCobrarPagarSujetoAdetraccion { get; set; }
        public decimal CpCobrarPagarMontoPercepcion { get; set; }
        public decimal CpCobrarPagarSaldoPercepcion { get; set; }
        public int CpIdrelacion { get; set; }
        public string RelacionTipoCpOrigen { get; set; } = null!;
        public string RelacionBalanceOrigenA { get; set; } = null!;
        public string RelacionBalanceOrigenB { get; set; } = null!;
        public string RelacionCardinalidad { get; set; } = null!;
        public string RelacionPropiedadReferencia { get; set; } = null!;
        public string RelacionPropiedadBalance { get; set; } = null!;
        public string RelacionTipoRelacion { get; set; } = null!;
        public string? CpCobrarPagarNumeroDetraccion { get; set; }
        public DateTime? CpCobrarPagarFechaDetraccion { get; set; }
        public decimal CpAjusteImpuesto { get; set; }
        public int IdcentroDeCosto { get; set; }
        public string TipoDocPago { get; set; } = null!;
        public DateTime CpCobrarPagarFechaPago { get; set; }
        public string CpNumCpReferenciado { get; set; } = null!;
        public bool CpEvaluarPercepcion { get; set; }
        public bool CpEvaluarDetraccion { get; set; }
        public bool CpSumarPercepcionAlTotal { get; set; }
        public decimal CpMontoPercepcion { get; set; }
        public decimal CpMontoDetraccion { get; set; }
    }
}

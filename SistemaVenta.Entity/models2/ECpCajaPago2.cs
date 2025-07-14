using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ECpCajaPago2
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
        public bool? CpCobrarPagarAplicaPercepcion { get; set; }
        public decimal? CpCobrarPagarMontoPercepcion { get; set; }
        public decimal? CpCobrarPagarPorcentajePercepcion { get; set; }
        public decimal? CpCobrarPagarSaldoPercepcion { get; set; }
        public int? CpCobrarPagarMovSaldo { get; set; }
        public int CpCajaPago2Idcp { get; set; }
        public int CpCajaPago2IdcpCaja { get; set; }
        public int CpCajaPago2CpCajaId { get; set; }
        public int CpCajaPago2CpCajaIdcaja { get; set; }
        public int CpCajaPago2CpCajaIdmoneda { get; set; }
        public int CpCajaPago2CpCajaMovSaldoContable { get; set; }
        public int CpCajaPago2CpCajaMovSaldoDisponible { get; set; }
        public string CpCajaPago2CpCajaTipoCpCaja { get; set; } = null!;
        public decimal CpCajaPago2CpCajaTotal { get; set; }
        public bool CpCajaPago2CpCajaActualizarNumeracionCheque { get; set; }
        public bool CpCajaPago2CpCajaMonedaBase { get; set; }
        public int CpCajaPago2CpCajaIdmedioDePago { get; set; }
        public int MedioDePagoId { get; set; }
        public int MedioDePagoIdmoneda { get; set; }
        public int MedioDePagoIdcajaUbicacion { get; set; }
        public int MedioDePagoIdtipoMedioDePago { get; set; }
        public int MedioDePagoIdpersona { get; set; }
        public int MedioDePagoIdtipoPersona { get; set; }
        public int MedioDePagoIdbanco { get; set; }
        public int MedioDePagoIdtarjetaCredito { get; set; }
        public DateTime MedioDePagoFechaPago { get; set; }
        public DateTime MedioDePagoFechaEmision { get; set; }
        public string MedioDePagoEstado { get; set; } = null!;
        public string MedioDePagoNumeroDocumento { get; set; } = null!;
        public string MedioDePagoObservacion { get; set; } = null!;
        public decimal MedioDePagoTotal { get; set; }
        public bool MedioDePagoTercero { get; set; }
        public bool MedioDePagoAnulado { get; set; }
        public int MedioDePagoIdcpCaja { get; set; }
        public bool Revisado { get; set; }
        public string MedioDePagoPersonaNombre { get; set; } = null!;
        public string? CpCobrarPagarNumeroDetraccion { get; set; }
        public DateTime? CpCobrarPagarFechaDetraccion { get; set; }
        public decimal AjusteImpuesto { get; set; }
        public string NumCpReferenciado { get; set; } = null!;
    }
}

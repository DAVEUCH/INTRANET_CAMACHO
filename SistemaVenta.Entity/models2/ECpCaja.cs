using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ECpCaja
    {
        public int CpCajaEntradaIdcp { get; set; }
        public int CpCajaEntradaCpsCajaId { get; set; }
        public int CpCajaEntradaCpsCajaPkid { get; set; }
        public int CpCajaEntradaCpsCajaIdcaja { get; set; }
        public int CpCajaEntradaCpsCajaIdmoneda { get; set; }
        public int CpCajaEntradaCpsCajaMovSaldoContable { get; set; }
        public int CpCajaEntradaCpsCajaMovSaldoDisponible { get; set; }
        public string CpCajaEntradaCpsCajaTipoCpCaja { get; set; } = null!;
        public decimal CpCajaEntradaCpsCajaTotal { get; set; }
        public int CpCajaEntradaCpsCajaIdmedioDePago { get; set; }
        public bool CpCajaEntradaCpsCajaActualizarNumeracionCheque { get; set; }
        public bool CpCajaEntradaCpsCajaMonedaBase { get; set; }
        public int CpCajaSalidaIdcp { get; set; }
        public int CpCajaSalidaCpsCajaId { get; set; }
        public int CpCajaSalidaCpsCajaPkid { get; set; }
        public int CpCajaSalidaCpsCajaIdcaja { get; set; }
        public int CpCajaSalidaCpsCajaIdmoneda { get; set; }
        public int CpCajaSalidaCpsCajaMovSaldoContable { get; set; }
        public int CpCajaSalidaCpsCajaMovSaldoDisponible { get; set; }
        public string CpCajaSalidaCpsCajaTipoCpCaja { get; set; } = null!;
        public decimal CpCajaSalidaCpsCajaTotal { get; set; }
        public int CpCajaSalidaCpsCajaIdmedioDePago { get; set; }
        public bool CpCajaSalidaCpsCajaActualizarNumeracionCheque { get; set; }
        public bool CpCajaSalidaCpsCajaMonedaBase { get; set; }
        public int CpCajaTransferenciaIdcp { get; set; }
        public int CpCajaTransferenciaCpsCajaId { get; set; }
        public int CpCajaTransferenciaCpsCajaPkid { get; set; }
        public int CpCajaTransferenciaCpsCajaIdcaja { get; set; }
        public int CpCajaTransferenciaCpsCajaIdmoneda { get; set; }
        public int CpCajaTransferenciaCpsCajaMovSaldoContable { get; set; }
        public int CpCajaTransferenciaCpsCajaMovSaldoDisponible { get; set; }
        public string CpCajaTransferenciaCpsCajaTipoCpCaja { get; set; } = null!;
        public decimal CpCajaTransferenciaCpsCajaTotal { get; set; }
        public int CpCajaTransferenciaCpsCajaIdmedioDePago { get; set; }
        public bool CpCajaTransferenciaCpsCajaActualizarNumeracionCheque { get; set; }
        public bool CpCajaTransferenciaCpsCajaMonedaBase { get; set; }
        public int MedioDePagoId { get; set; }
        public int MedioDePagoPkid { get; set; }
        public int MedioDePagoIdmoneda { get; set; }
        public int MedioDePagoIdtarjetaCredito { get; set; }
        public int MedioDePagoIdcajaUbicacion { get; set; }
        public int MedioDePagoIdtipoMedioDePago { get; set; }
        public DateTime MedioDePagoFechaPago { get; set; }
        public DateTime MedioDePagoFechaEmision { get; set; }
        public string MedioDePagoEstado { get; set; } = null!;
        public string MedioDePagoNumeroDocumento { get; set; } = null!;
        public string MedioDePagoObservacion { get; set; } = null!;
        public decimal MedioDePagoTotal { get; set; }
        public bool MedioDePagoTercero { get; set; }
        public int MedioDePagoIdpersona { get; set; }
        public int MedioDePagoIdtipoPersona { get; set; }
        public int MedioDePagoIdbanco { get; set; }
        public bool MedioDePagoAnulado { get; set; }
        public int MedioDePagoIdcpCaja { get; set; }
        public string MedioDePagoPersonaNombre { get; set; } = null!;
    }
}

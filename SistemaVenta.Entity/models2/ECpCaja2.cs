using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ECpCaja2
    {
        public int CpCajaTransferenciaIdcp { get; set; }
        public int CpCajaTransferenciaCpsCajaSalidaId { get; set; }
        public int CpCajaTransferenciaCpsCajaSalidaIdcaja { get; set; }
        public int CpCajaTransferenciaCpsCajaSalidaIdmoneda { get; set; }
        public int CpCajaTransferenciaCpsCajaSalidaIdmedioDePago { get; set; }
        public int CpCajaTransferenciaCpsCajaSalidaMovSaldoContable { get; set; }
        public int CpCajaTransferenciaCpsCajaSalidaMovSaldoDisponible { get; set; }
        public string CpCajaTransferenciaCpsCajaSalidaTipoCpCaja { get; set; } = null!;
        public decimal CpCajaTransferenciaCpsCajaSalidaTotal { get; set; }
        public int CpCajaTransferenciaCpsCajaEntradaId { get; set; }
        public int CpCajaTransferenciaCpsCajaEntradaIdcaja { get; set; }
        public int CpCajaTransferenciaCpsCajaEntradaIdmoneda { get; set; }
        public int IdmedioDePago { get; set; }
        public int CpCajaTransferenciaCpsCajaEntradaMovSaldoContable { get; set; }
        public int CpCajaTransferenciaCpsCajaEntradaMovSaldoDisponible { get; set; }
        public string CpCajaTransferenciaCpsCajaEntradaTipoCpCaja { get; set; } = null!;
        public decimal CpCajaTransferenciaCpsCajaEntradaTotal { get; set; }
        public bool Efectivo { get; set; }
        public bool CpCajaTransferenciaCpsCajaEntradaActualizarNumeracionCheque { get; set; }
        public bool CpCajaTransferenciaCpsCajaEntradaMonedaBase { get; set; }
        public bool CpCajaTransferenciaCpsCajaSalidaActualizarNumeracionCheque { get; set; }
        public bool CpCajaTransferenciaCpsCajaSalidaMonedaBase { get; set; }
    }
}

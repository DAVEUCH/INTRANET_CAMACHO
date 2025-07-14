using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class CpCaja
    {
        public CpCaja()
        {
            CpCajaPago2s = new HashSet<CpCajaPago2>();
            CpConfirmarMedioPagos = new HashSet<CpConfirmarMedioPago>();
            ItemCpCajaEntradaSalidumIdcpCajaEntradaNavigations = new HashSet<ItemCpCajaEntradaSalidum>();
            ItemCpCajaEntradaSalidumIdcpCajaSalidaNavigations = new HashSet<ItemCpCajaEntradaSalidum>();
            ItemCpCajaPagos = new HashSet<ItemCpCajaPago>();
            MedioDePagos = new HashSet<MedioDePago>();
        }

        public int Pkid { get; set; }
        public int Idcp { get; set; }
        public int Idcaja { get; set; }
        public int Idmoneda { get; set; }
        public int IdmedioDePago { get; set; }
        public int MovSaldoContable { get; set; }
        public int MovSaldoDisponible { get; set; }
        public string TipoCpCaja { get; set; } = null!;
        public decimal Total { get; set; }
        public bool ActualizarNumeracionCheque { get; set; }
        public bool MonedaBase { get; set; }

        public virtual Caja IdcajaNavigation { get; set; } = null!;
        public virtual Cp IdcpNavigation { get; set; } = null!;
        public virtual MedioDePago IdmedioDePagoNavigation { get; set; } = null!;
        public virtual Monedum IdmonedaNavigation { get; set; } = null!;
        public virtual ICollection<CpCajaPago2> CpCajaPago2s { get; set; }
        public virtual ICollection<CpConfirmarMedioPago> CpConfirmarMedioPagos { get; set; }
        public virtual ICollection<ItemCpCajaEntradaSalidum> ItemCpCajaEntradaSalidumIdcpCajaEntradaNavigations { get; set; }
        public virtual ICollection<ItemCpCajaEntradaSalidum> ItemCpCajaEntradaSalidumIdcpCajaSalidaNavigations { get; set; }
        public virtual ICollection<ItemCpCajaPago> ItemCpCajaPagos { get; set; }
        public virtual ICollection<MedioDePago> MedioDePagos { get; set; }
    }
}

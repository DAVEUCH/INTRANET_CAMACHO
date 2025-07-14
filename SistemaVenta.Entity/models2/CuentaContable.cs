using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class CuentaContable
    {
        public CuentaContable()
        {
            ActivoFijoActivoFijos = new HashSet<ActivoFijoActivoFijo>();
            CargoAbonos = new HashSet<CargoAbono>();
            ConfiguracionConciliacionBancariumIdcuentaContableCpCajaEntradaNavigations = new HashSet<ConfiguracionConciliacionBancarium>();
            ConfiguracionConciliacionBancariumIdcuentaContableCpCajaSalidaNavigations = new HashSet<ConfiguracionConciliacionBancarium>();
            ConfiguracionDocCobrarPagars = new HashSet<ConfiguracionDocCobrarPagar>();
            CptoOperacionCuentaContables = new HashSet<CptoOperacionCuentaContable>();
            CuentaContableCentroCostos = new HashSet<CuentaContableCentroCosto>();
            CuentaContableCierreAperturas = new HashSet<CuentaContableCierreApertura>();
            CuentaTransferenciaAbonoIdcuentaContableAbonoNavigations = new HashSet<CuentaTransferenciaAbono>();
            CuentaTransferenciaAbonoIdcuentaContableNavigations = new HashSet<CuentaTransferenciaAbono>();
            CuentaTransferenciaCargos = new HashSet<CuentaTransferenciaCargo>();
            DistribucionCostosCuentasContables = new HashSet<DistribucionCostosCuentasContable>();
            DocCobrarPagars = new HashSet<DocCobrarPagar>();
            EstadoFinancieroRubroCuentaContables = new HashSet<EstadoFinancieroRubroCuentaContable>();
            ItemCpOrdenPagos = new HashSet<ItemCpOrdenPago>();
            ItemCuentaContables = new HashSet<ItemCuentaContable>();
            ItemDocCobrarPagars = new HashSet<ItemDocCobrarPagar>();
            MapeoCuentaContables = new HashSet<MapeoCuentaContable>();
            PropiedadCasoContables = new HashSet<PropiedadCasoContable>();
            SaldoPeriodoCuentaContables = new HashSet<SaldoPeriodoCuentaContable>();
            SaldoPeriodoSegmentoCuentaContables = new HashSet<SaldoPeriodoSegmentoCuentaContable>();
        }

        public int Pkid { get; set; }
        public int? IdplanCuentas { get; set; }
        public int? IdcuentaContablePadre { get; set; }
        public int? Idmoneda { get; set; }
        public string? Cuenta { get; set; }
        public string? Descripcion { get; set; }
        public string? TipoCuenta { get; set; }
        public string? GlosaTransferencia { get; set; }
        public int? Subcuentas { get; set; }
        public int? Nivel { get; set; }
        public decimal? Saldo { get; set; }
        public bool? TieneTransferencia { get; set; }
        public bool? CentroCostos { get; set; }
        public string? EntidadAsociada { get; set; }
        public string? TipoEntidadAsociada { get; set; }
        public bool? Caja { get; set; }
        public bool? Gastos { get; set; }
        public bool? CuentaCorriente { get; set; }
        public bool? ResumirEnLibroMayor { get; set; }
        public bool? SujetoAdetraccion { get; set; }
        public decimal? PorcentajeDetraccion { get; set; }
        public bool ProrrateoAutomatico { get; set; }
        public bool RestringirCentroCostos { get; set; }
        public decimal MontoMinimoDetraccion { get; set; }

        public virtual ICollection<ActivoFijoActivoFijo> ActivoFijoActivoFijos { get; set; }
        public virtual ICollection<CargoAbono> CargoAbonos { get; set; }
        public virtual ICollection<ConfiguracionConciliacionBancarium> ConfiguracionConciliacionBancariumIdcuentaContableCpCajaEntradaNavigations { get; set; }
        public virtual ICollection<ConfiguracionConciliacionBancarium> ConfiguracionConciliacionBancariumIdcuentaContableCpCajaSalidaNavigations { get; set; }
        public virtual ICollection<ConfiguracionDocCobrarPagar> ConfiguracionDocCobrarPagars { get; set; }
        public virtual ICollection<CptoOperacionCuentaContable> CptoOperacionCuentaContables { get; set; }
        public virtual ICollection<CuentaContableCentroCosto> CuentaContableCentroCostos { get; set; }
        public virtual ICollection<CuentaContableCierreApertura> CuentaContableCierreAperturas { get; set; }
        public virtual ICollection<CuentaTransferenciaAbono> CuentaTransferenciaAbonoIdcuentaContableAbonoNavigations { get; set; }
        public virtual ICollection<CuentaTransferenciaAbono> CuentaTransferenciaAbonoIdcuentaContableNavigations { get; set; }
        public virtual ICollection<CuentaTransferenciaCargo> CuentaTransferenciaCargos { get; set; }
        public virtual ICollection<DistribucionCostosCuentasContable> DistribucionCostosCuentasContables { get; set; }
        public virtual ICollection<DocCobrarPagar> DocCobrarPagars { get; set; }
        public virtual ICollection<EstadoFinancieroRubroCuentaContable> EstadoFinancieroRubroCuentaContables { get; set; }
        public virtual ICollection<ItemCpOrdenPago> ItemCpOrdenPagos { get; set; }
        public virtual ICollection<ItemCuentaContable> ItemCuentaContables { get; set; }
        public virtual ICollection<ItemDocCobrarPagar> ItemDocCobrarPagars { get; set; }
        public virtual ICollection<MapeoCuentaContable> MapeoCuentaContables { get; set; }
        public virtual ICollection<PropiedadCasoContable> PropiedadCasoContables { get; set; }
        public virtual ICollection<SaldoPeriodoCuentaContable> SaldoPeriodoCuentaContables { get; set; }
        public virtual ICollection<SaldoPeriodoSegmentoCuentaContable> SaldoPeriodoSegmentoCuentaContables { get; set; }
    }
}

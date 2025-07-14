using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class CentroDeCosto
    {
        public CentroDeCosto()
        {
            CargoAbonos = new HashSet<CargoAbono>();
            ConfiguracionConciliacionBancaria = new HashSet<ConfiguracionConciliacionBancarium>();
            CuentaContableCentroCostos = new HashSet<CuentaContableCentroCosto>();
            InverseIdcentroDeCostoPadreNavigation = new HashSet<CentroDeCosto>();
            ItemCpOrdenPagos = new HashSet<ItemCpOrdenPago>();
            ItemCuentaContables = new HashSet<ItemCuentaContable>();
            ItemProductos = new HashSet<ItemProducto>();
        }

        public int Pkid { get; set; }
        public int IdcentroDeCostoPadre { get; set; }
        public int IdplanCuentas { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int Nivel { get; set; }
        public bool Activo { get; set; }

        public virtual CentroDeCosto IdcentroDeCostoPadreNavigation { get; set; } = null!;
        public virtual PlanCuenta IdplanCuentasNavigation { get; set; } = null!;
        public virtual ICollection<CargoAbono> CargoAbonos { get; set; }
        public virtual ICollection<ConfiguracionConciliacionBancarium> ConfiguracionConciliacionBancaria { get; set; }
        public virtual ICollection<CuentaContableCentroCosto> CuentaContableCentroCostos { get; set; }
        public virtual ICollection<CentroDeCosto> InverseIdcentroDeCostoPadreNavigation { get; set; }
        public virtual ICollection<ItemCpOrdenPago> ItemCpOrdenPagos { get; set; }
        public virtual ICollection<ItemCuentaContable> ItemCuentaContables { get; set; }
        public virtual ICollection<ItemProducto> ItemProductos { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class DocCobrarPagar
    {
        public DocCobrarPagar()
        {
            CargoAbonos = new HashSet<CargoAbono>();
            ItemCpOrdenPagos = new HashSet<ItemCpOrdenPago>();
            ItemDocCobrarPagarConsolidadoCargas = new HashSet<ItemDocCobrarPagarConsolidadoCarga>();
            ItemDocCobrarPagars = new HashSet<ItemDocCobrarPagar>();
            ItemGastoImportacion2s = new HashSet<ItemGastoImportacion2>();
            ItemGastoImportacions = new HashSet<ItemGastoImportacion>();
        }

        public int Pkid { get; set; }
        public int IdcargoAbono { get; set; }
        public int Idcp { get; set; }
        public int IdcuentaContable { get; set; }
        public int Idauxiliar { get; set; }
        public decimal Saldo { get; set; }
        public decimal Total { get; set; }
        public DateTime FechaUltimoPago { get; set; }
        public bool Pagado { get; set; }
        public int IdcentroDeCosto { get; set; }
        public string TipoDocPago { get; set; } = null!;

        public virtual CargoAbono IdcargoAbonoNavigation { get; set; } = null!;
        public virtual Cp IdcpNavigation { get; set; } = null!;
        public virtual CuentaContable IdcuentaContableNavigation { get; set; } = null!;
        public virtual ICollection<CargoAbono> CargoAbonos { get; set; }
        public virtual ICollection<ItemCpOrdenPago> ItemCpOrdenPagos { get; set; }
        public virtual ICollection<ItemDocCobrarPagarConsolidadoCarga> ItemDocCobrarPagarConsolidadoCargas { get; set; }
        public virtual ICollection<ItemDocCobrarPagar> ItemDocCobrarPagars { get; set; }
        public virtual ICollection<ItemGastoImportacion2> ItemGastoImportacion2s { get; set; }
        public virtual ICollection<ItemGastoImportacion> ItemGastoImportacions { get; set; }
    }
}

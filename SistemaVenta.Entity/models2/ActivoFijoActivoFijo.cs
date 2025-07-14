using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ActivoFijoActivoFijo
    {
        public ActivoFijoActivoFijo()
        {
            ItemCpActivoFijos = new HashSet<ItemCpActivoFijo>();
        }

        public int Pkid { get; set; }
        public DateTime FechaAdquisicion { get; set; }
        public DateTime FechaActivacion { get; set; }
        public bool Activado { get; set; }
        public string NumeroSerie { get; set; } = null!;
        public decimal PorcentajeDepreciacion { get; set; }
        public bool Tangible { get; set; }
        public int IdmetodoDepreciacion { get; set; }
        public int IdcuentaContable { get; set; }
        public int Idubicacion { get; set; }
        public string Modelo { get; set; } = null!;
        public int? IdcuentaContable2 { get; set; }
        public int? IdcuentaContable3 { get; set; }

        public virtual CuentaContable IdcuentaContableNavigation { get; set; } = null!;
        public virtual ActivoFijoMetodoDepreciacion IdmetodoDepreciacionNavigation { get; set; } = null!;
        public virtual Producto Pk { get; set; } = null!;
        public virtual ICollection<ItemCpActivoFijo> ItemCpActivoFijos { get; set; }
    }
}

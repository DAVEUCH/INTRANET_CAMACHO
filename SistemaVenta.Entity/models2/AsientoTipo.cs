using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class AsientoTipo
    {
        public AsientoTipo()
        {
            CargoAbonoTipos = new HashSet<CargoAbonoTipo>();
            CasoContables = new HashSet<CasoContable>();
        }

        public int Pkid { get; set; }
        public int IdcptoOperacion { get; set; }
        public int IdlibroAuxiliar { get; set; }
        public string Glosa { get; set; } = null!;
        public bool ResumirEnLibroDiario { get; set; }

        public virtual CptoOperacion IdcptoOperacionNavigation { get; set; } = null!;
        public virtual LibroAuxiliar IdlibroAuxiliarNavigation { get; set; } = null!;
        public virtual ICollection<CargoAbonoTipo> CargoAbonoTipos { get; set; }
        public virtual ICollection<CasoContable> CasoContables { get; set; }
    }
}

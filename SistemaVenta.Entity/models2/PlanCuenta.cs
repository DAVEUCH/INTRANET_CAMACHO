using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class PlanCuenta
    {
        public PlanCuenta()
        {
            CentroDeCostos = new HashSet<CentroDeCosto>();
        }

        public int Pkid { get; set; }
        public int Nivel { get; set; }
        public string IdtipoAsociado { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int NivelCentroDeCosto { get; set; }

        public virtual Clasificador IdtipoAsociadoNavigation { get; set; } = null!;
        public virtual ICollection<CentroDeCosto> CentroDeCostos { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class NivelVendedor
    {
        public NivelVendedor()
        {
            CargosJeves = new HashSet<CargosJefe>();
            EscalaComisions = new HashSet<EscalaComision>();
        }

        public int Pkid { get; set; }
        public string Tipo { get; set; } = null!;
        public int? IdComision { get; set; }
        public int? IdTipoNivel { get; set; }

        public virtual Comision? IdComisionNavigation { get; set; }
        public virtual TipoNivel? IdTipoNivelNavigation { get; set; }
        public virtual ICollection<CargosJefe> CargosJeves { get; set; }
        public virtual ICollection<EscalaComision> EscalaComisions { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class CasoContable
    {
        public CasoContable()
        {
            PropiedadCasoContables = new HashSet<PropiedadCasoContable>();
        }

        public int Pkid { get; set; }
        public int IdasientoTipo { get; set; }
        public string Glosa { get; set; } = null!;

        public virtual AsientoTipo IdasientoTipoNavigation { get; set; } = null!;
        public virtual ICollection<PropiedadCasoContable> PropiedadCasoContables { get; set; }
    }
}

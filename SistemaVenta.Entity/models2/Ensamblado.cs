using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Ensamblado
    {
        public Ensamblado()
        {
            Clasificadors = new HashSet<Clasificador>();
        }

        public string Pkid { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string EspacioNombre { get; set; } = null!;

        public virtual ICollection<Clasificador> Clasificadors { get; set; }
    }
}

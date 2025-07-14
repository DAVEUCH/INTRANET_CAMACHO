using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TipoTercero
    {
        public TipoTercero()
        {
            Personas = new HashSet<Persona>();
        }

        public int Pkid { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;

        public virtual ICollection<Persona> Personas { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Telefono
    {
        public int Pkid { get; set; }
        public int Idpersona { get; set; }
        public string NumeroTelefono { get; set; } = null!;
        public string TipoTelefono { get; set; } = null!;
        public bool Principal { get; set; }

        public virtual Persona IdpersonaNavigation { get; set; } = null!;
    }
}

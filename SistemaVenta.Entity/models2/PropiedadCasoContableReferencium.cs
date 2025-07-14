using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class PropiedadCasoContableReferencium
    {
        public int Pkid { get; set; }
        public int IdpropiedadCasoContable { get; set; }
        public string RutaPropiedadReferencia { get; set; } = null!;

        public virtual PropiedadCasoContable IdpropiedadCasoContableNavigation { get; set; } = null!;
    }
}

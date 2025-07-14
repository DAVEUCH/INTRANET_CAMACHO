using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EPropiedadCasoContableReferencium
    {
        public int PropiedadesReferenciaId { get; set; }
        public int IdpropiedadCasoContable { get; set; }
        public string PropiedadesReferenciaRutaPropiedadReferencia { get; set; } = null!;
    }
}

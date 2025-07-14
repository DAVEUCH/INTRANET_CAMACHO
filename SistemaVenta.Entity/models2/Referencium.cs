using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Referencium
    {
        public string Pkid { get; set; } = null!;
        public string IdtipoReferenciado { get; set; } = null!;
        public bool ResuelveSombra { get; set; }
        public bool EsContenido { get; set; }
        public bool EsContenedor { get; set; }
        public string RutaIndice { get; set; } = null!;

        public virtual CaracteristicaEstructural Pk { get; set; } = null!;
    }
}

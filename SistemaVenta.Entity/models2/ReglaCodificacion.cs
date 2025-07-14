using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ReglaCodificacion
    {
        public string Pkid { get; set; } = null!;
        public string IdtipoReferenciado { get; set; } = null!;
        public string Ruta { get; set; } = null!;
        public bool Autonumerico { get; set; }
        public int LongitudNumero { get; set; }
        public bool ReiniciarNumeracion { get; set; }
        public string RutaAtributoCodificacion { get; set; } = null!;
        public bool? Habilitado { get; set; }

        public virtual Clasificador IdtipoReferenciadoNavigation { get; set; } = null!;
    }
}

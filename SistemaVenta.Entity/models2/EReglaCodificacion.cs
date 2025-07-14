using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EReglaCodificacion
    {
        public string Id { get; set; } = null!;
        public string IdtipoReferenciado { get; set; } = null!;
        public string Ruta { get; set; } = null!;
        public bool Autonumerico { get; set; }
        public int LongitudNumero { get; set; }
        public bool ReiniciarNumeracion { get; set; }
        public string RutaAtributoCodificacion { get; set; } = null!;
        public bool Habilitado { get; set; }
    }
}

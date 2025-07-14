using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ReglaCodificacionNumeracion
    {
        public int Pkid { get; set; }
        public string Idregla { get; set; } = null!;
        public string Ruta { get; set; } = null!;
        public int Numeracion { get; set; }
    }
}

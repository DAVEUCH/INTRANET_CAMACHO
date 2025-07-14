using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VSeleccionActivo
    {
        public int Idproducto { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string NumeroSerie { get; set; } = null!;
        public string Modelo { get; set; } = null!;
        public bool Activado { get; set; }
        public int Idubicacion { get; set; }
    }
}

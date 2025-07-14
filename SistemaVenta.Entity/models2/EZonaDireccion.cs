using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EZonaDireccion
    {
        public int Id { get; set; }
        public int Idzona { get; set; }
        public string Iddireccion { get; set; } = null!;
        public string DireccionIddireccion { get; set; } = null!;
        public int DireccionZonasIdzona { get; set; }
    }
}

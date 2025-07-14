using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EDerechoPropiedad
    {
        public int Idrol { get; set; }
        public int DerechosPropiedadId { get; set; }
        public string DerechosPropiedadNombrePropiedad { get; set; } = null!;
        public bool DerechosPropiedadLeer { get; set; }
        public bool DerechosPropiedadEscribir { get; set; }
    }
}

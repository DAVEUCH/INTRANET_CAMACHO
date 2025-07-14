using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Verificacion
    {
        public DateTime Fecha { get; set; }
        public int Idalmacen { get; set; }
        public int Pkid { get; set; }
        public int Idcp { get; set; }
    }
}

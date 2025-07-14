using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Servicio
    {
        public int Pkid { get; set; }
        public string Descripcion2 { get; set; } = null!;

        public virtual ProductoServicio Pk { get; set; } = null!;
    }
}

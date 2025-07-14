using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Prodimagenes2
    {
        public int Pkid { get; set; }
        public string Codigo { get; set; } = null!;
        public string ImagenProducto { get; set; } = null!;
    }
}

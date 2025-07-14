using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvUnidadActiva
    {
        public int Pkid { get; set; }
        public string Descripcion { get; set; } = null!;
        public string Abreviacion { get; set; } = null!;
        public bool Base { get; set; }
        public int Factor { get; set; }
        public int? IdproductoServicio { get; set; }
    }
}

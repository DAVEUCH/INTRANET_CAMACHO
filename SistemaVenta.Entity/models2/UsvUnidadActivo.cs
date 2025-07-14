using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvUnidadActivo
    {
        public int Pkid { get; set; }
        public string Abreviacion { get; set; } = null!;
        public int? IdProductoServicio { get; set; }
        public int Factor { get; set; }
        public decimal Peso { get; set; }
    }
}

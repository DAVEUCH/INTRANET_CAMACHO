using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptRutaVendedor
    {
        public int Idvendedor { get; set; }
        public int Idzona { get; set; }
        public int Idcliente { get; set; }
        public int Iddireccion { get; set; }
        public string DiaDeSemana { get; set; } = null!;
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
    }
}

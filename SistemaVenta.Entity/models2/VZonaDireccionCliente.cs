using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VZonaDireccionCliente
    {
        public int Id { get; set; }
        public int Idvendedor { get; set; }
        public int Idcliente { get; set; }
        public string DiaDeSemana { get; set; } = null!;
        public int Idzona { get; set; }
    }
}

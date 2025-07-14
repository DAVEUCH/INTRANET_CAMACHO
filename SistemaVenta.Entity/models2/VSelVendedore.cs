using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VSelVendedore
    {
        public int Idvendedor { get; set; }
        public string CodigoVendedor { get; set; } = null!;
        public string NombreVendedor { get; set; } = null!;
        public bool Descriptivo { get; set; }
        public string DiaDeSemana { get; set; } = null!;
    }
}

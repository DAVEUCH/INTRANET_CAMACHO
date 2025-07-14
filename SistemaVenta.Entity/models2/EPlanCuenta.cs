using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EPlanCuenta
    {
        public int Id { get; set; }
        public int Nivel { get; set; }
        public string IdtipoAsociado { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int NivelCentroDeCosto { get; set; }
    }
}

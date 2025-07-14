using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteEgpporNaturalezaAuxiliar
    {
        public int Idnivel1 { get; set; }
        public int Idnivel2 { get; set; }
        public string Nivel1 { get; set; } = null!;
        public string Nivel2 { get; set; } = null!;
        public string Cuenta { get; set; } = null!;
        public int Idperiodo { get; set; }
    }
}

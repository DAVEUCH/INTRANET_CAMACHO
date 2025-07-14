using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptAlmapoLiquidacionRepartoAuxiliar1
    {
        public int IdconsolidadoCarga { get; set; }
        public int Idcp { get; set; }
        public string Tipo { get; set; } = null!;
        public int Orden { get; set; }
        public string Grupo { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteConsolidadoCargaDocPagoAuxiliar
    {
        public int IdconsolidadoCarga { get; set; }
        public int Idcp { get; set; }
        public string Seccion { get; set; } = null!;
        public int Movimiento { get; set; }
    }
}

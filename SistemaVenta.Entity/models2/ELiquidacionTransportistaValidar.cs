using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ELiquidacionTransportistaValidar
    {
        public int Idprestamo { get; set; }
        public int Idgasto { get; set; }
        public string Numero { get; set; } = null!;
    }
}

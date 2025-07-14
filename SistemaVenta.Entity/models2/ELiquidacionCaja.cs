using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ELiquidacionCaja
    {
        public int Id { get; set; }
        public int Idcaja { get; set; }
        public int IdtipoCp { get; set; }
        public DateTime Fecha { get; set; }
        public string NumCp { get; set; } = null!;
        public int IdturnoCaja { get; set; }
        public string Observacion1 { get; set; } = null!;
        public string Observacion2 { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ETurnoCaja
    {
        public int Id { get; set; }
        public int Idcaja { get; set; }
        public int Idresponsable { get; set; }
        public DateTime Fecha { get; set; }
        public string Hora { get; set; } = null!;
        public bool Cerrado { get; set; }
        public string HoraCierre { get; set; } = null!;
    }
}

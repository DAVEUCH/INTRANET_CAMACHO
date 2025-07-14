using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EFuerzaVenta
    {
        public int Id { get; set; }
        public int Iddivision { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Observacion { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EEstadoFinanciero
    {
        public int Pkid { get; set; }
        public int Id { get; set; }
        public string Descripcion { get; set; } = null!;
        public int Niveles { get; set; }
        public string Codigo { get; set; } = null!;
    }
}

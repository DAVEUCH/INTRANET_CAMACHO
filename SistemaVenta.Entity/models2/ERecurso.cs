using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ERecurso
    {
        public int Id { get; set; }
        public int Idhorario { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
    }
}

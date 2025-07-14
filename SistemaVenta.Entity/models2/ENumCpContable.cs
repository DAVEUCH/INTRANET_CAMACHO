using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ENumCpContable
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } = null!;
        public int Serie { get; set; }
        public int Longitud { get; set; }
    }
}

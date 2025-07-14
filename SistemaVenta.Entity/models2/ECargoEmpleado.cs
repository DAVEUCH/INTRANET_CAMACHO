using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ECargoEmpleado
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } = null!;
        public bool Vendedor { get; set; }
    }
}

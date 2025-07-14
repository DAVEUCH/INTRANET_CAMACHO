using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EModalidadCredito
    {
        public int Id { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int DiasCredito { get; set; }
    }
}

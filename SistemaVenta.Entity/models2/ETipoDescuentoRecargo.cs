using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ETipoDescuentoRecargo
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } = null!;
        public string DescuentoRecargo { get; set; } = null!;
        public int Automatico { get; set; }
    }
}

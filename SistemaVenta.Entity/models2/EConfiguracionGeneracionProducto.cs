using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EConfiguracionGeneracionProducto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } = null!;
        public string IdtipoAsociado { get; set; } = null!;
    }
}

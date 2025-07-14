using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ECaracteristica
    {
        public int Id { get; set; }
        public int IdtipoCaracteristica { get; set; }
        public string Descripcion { get; set; } = null!;
        public string Codigo { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EConfiguracionDistribucionCola
    {
        public int Id { get; set; }
        public string? Descripcion { get; set; }
        public string? IdtipoReferenciado { get; set; }
    }
}

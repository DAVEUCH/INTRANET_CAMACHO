using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EConfiguracionReporte
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } = null!;
        public int Idusuario { get; set; }
        public string IdtipoReporte { get; set; } = null!;
    }
}

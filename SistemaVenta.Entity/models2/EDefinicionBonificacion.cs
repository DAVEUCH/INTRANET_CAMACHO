using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EDefinicionBonificacion
    {
        public int Id { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string IdtipoAsociado { get; set; } = null!;
        public bool Activo { get; set; }
        public bool Historico { get; set; }
        public int IdbonificacionHistorica { get; set; }
        public decimal Version { get; set; }
    }
}

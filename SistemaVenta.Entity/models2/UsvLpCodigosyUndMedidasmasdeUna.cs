using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvLpCodigosyUndMedidasmasdeUna
    {
        public string Descripcion { get; set; } = null!;
        public string Marca { get; set; } = null!;
        public string Codigo { get; set; } = null!;
        public string? UnidadesDeMedidas { get; set; }
        public string? UnidadMedidaActivo { get; set; }
    }
}

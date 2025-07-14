using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VMoranMetaCuotaVendedore
    {
        public int? Idvendedor { get; set; }
        public decimal? MetaCuota { get; set; }
        public int? CabIdComisionCuota { get; set; }
        public string Tipo { get; set; } = null!;
        public string TipoGrupo { get; set; } = null!;
        public string? Descripcion { get; set; }
        public int IdNivelVendedor { get; set; }
    }
}

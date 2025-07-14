using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VMoranAgrupacionComisionVendedore
    {
        public int PkId { get; set; }
        public string Tipo { get; set; } = null!;
        public string TipoGrupo { get; set; } = null!;
        public string? Descripcion { get; set; }
        public int? IdAgrupacionCuotaVenta { get; set; }
        public string Nivel { get; set; } = null!;
        public int IdComision { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class CargosJefesCabComisionCuotum
    {
        public int PkId { get; set; }
        public int IdCargosJefes { get; set; }
        public int IdCabComisionCuota { get; set; }
        public string? TipoGrupo { get; set; }

        public virtual CabComisionCuotum IdCabComisionCuotaNavigation { get; set; } = null!;
        public virtual CargosJefe IdCargosJefesNavigation { get; set; } = null!;
    }
}

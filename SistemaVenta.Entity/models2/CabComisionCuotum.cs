using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class CabComisionCuotum
    {
        public CabComisionCuotum()
        {
            CargosJefesCabComisionCuota = new HashSet<CargosJefesCabComisionCuotum>();
            ComisionCuotaVenta = new HashSet<ComisionCuotaVentum>();
            EscalaComisions = new HashSet<EscalaComision>();
        }

        public int PkId { get; set; }
        public string Tipo { get; set; } = null!;
        public string TipoGrupo { get; set; } = null!;
        public string? Descripcion { get; set; }
        public int IdComision { get; set; }
        public int? IdTipoNivel { get; set; }

        public virtual Comision IdComisionNavigation { get; set; } = null!;
        public virtual TipoNivel? IdTipoNivelNavigation { get; set; }
        public virtual ICollection<CargosJefesCabComisionCuotum> CargosJefesCabComisionCuota { get; set; }
        public virtual ICollection<ComisionCuotaVentum> ComisionCuotaVenta { get; set; }
        public virtual ICollection<EscalaComision> EscalaComisions { get; set; }
    }
}

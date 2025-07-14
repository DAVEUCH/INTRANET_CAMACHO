using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class CargosJefe
    {
        public CargosJefe()
        {
            CargosJefesCabComisionCuota = new HashSet<CargosJefesCabComisionCuotum>();
            InverseIdSuperiorNavigation = new HashSet<CargosJefe>();
        }

        public int Pkid { get; set; }
        public int IdPersona { get; set; }
        public int IdNivelVendedor { get; set; }
        public int? IdSuperior { get; set; }
        public int? IdComision { get; set; }

        public virtual Comision? IdComisionNavigation { get; set; }
        public virtual NivelVendedor IdNivelVendedorNavigation { get; set; } = null!;
        public virtual CargosJefe? IdSuperiorNavigation { get; set; }
        public virtual ICollection<CargosJefesCabComisionCuotum> CargosJefesCabComisionCuota { get; set; }
        public virtual ICollection<CargosJefe> InverseIdSuperiorNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TipoNivel
    {
        public TipoNivel()
        {
            CabComisionCuota = new HashSet<CabComisionCuotum>();
            NivelVendedors = new HashSet<NivelVendedor>();
        }

        public int Pkid { get; set; }
        public string Nivel { get; set; } = null!;

        public virtual ICollection<CabComisionCuotum> CabComisionCuota { get; set; }
        public virtual ICollection<NivelVendedor> NivelVendedors { get; set; }
    }
}

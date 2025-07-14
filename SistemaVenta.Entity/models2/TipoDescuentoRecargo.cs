using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TipoDescuentoRecargo
    {
        public TipoDescuentoRecargo()
        {
            CpDescuentoRecargos = new HashSet<CpDescuentoRecargo>();
            DefinicionDescuento2s = new HashSet<DefinicionDescuento2>();
            DefinicionDescuentos = new HashSet<DefinicionDescuento>();
        }

        public int Pkid { get; set; }
        public string Descripcion { get; set; } = null!;
        public string DescuentoRecargo { get; set; } = null!;
        public int Automatico { get; set; }

        public virtual ICollection<CpDescuentoRecargo> CpDescuentoRecargos { get; set; }
        public virtual ICollection<DefinicionDescuento2> DefinicionDescuento2s { get; set; }
        public virtual ICollection<DefinicionDescuento> DefinicionDescuentos { get; set; }
    }
}

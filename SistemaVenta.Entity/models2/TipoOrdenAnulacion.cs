using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TipoOrdenAnulacion
    {
        public int Pkid { get; set; }
        public bool RequiereCpVenta { get; set; }
        public int Idalmacen { get; set; }

        public virtual Almacen IdalmacenNavigation { get; set; } = null!;
        public virtual TipoCp Pk { get; set; } = null!;
    }
}

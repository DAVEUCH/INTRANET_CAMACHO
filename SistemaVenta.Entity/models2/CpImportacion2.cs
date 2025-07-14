using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class CpImportacion2
    {
        public CpImportacion2()
        {
            ItemGastoImportacion2s = new HashSet<ItemGastoImportacion2>();
        }

        public int Pkid { get; set; }
        public int IdcpInventarioSalida { get; set; }

        public virtual CpInventario IdcpInventarioSalidaNavigation { get; set; } = null!;
        public virtual Cp Pk { get; set; } = null!;
        public virtual ICollection<ItemGastoImportacion2> ItemGastoImportacion2s { get; set; }
    }
}

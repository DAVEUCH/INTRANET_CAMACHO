using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class CpImportacion
    {
        public CpImportacion()
        {
            ItemGastoImportacions = new HashSet<ItemGastoImportacion>();
        }

        public int Pkid { get; set; }
        public int IdcpInventarioEntrada { get; set; }
        public int IdcpInventarioSalida { get; set; }

        public virtual CpInventario IdcpInventarioEntradaNavigation { get; set; } = null!;
        public virtual CpInventario IdcpInventarioSalidaNavigation { get; set; } = null!;
        public virtual Cp Pk { get; set; } = null!;
        public virtual ICollection<ItemGastoImportacion> ItemGastoImportacions { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemCajaTransferencium
    {
        public int Pkid { get; set; }
        public int IdcuentaContable { get; set; }
        public int IdcpCaja { get; set; }

        public virtual ItemCp Pk { get; set; } = null!;
    }
}

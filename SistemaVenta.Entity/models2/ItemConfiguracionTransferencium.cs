using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemConfiguracionTransferencium
    {
        public ItemConfiguracionTransferencium()
        {
            ItemConfiguracionEntradaSalida = new HashSet<ItemConfiguracionEntradaSalidum>();
        }

        public int Pkid { get; set; }
        public int IdconfiguracionTransferencia { get; set; }
        public int IdcajaEntrada { get; set; }
        public int IdcajaSalida { get; set; }

        public virtual ConfiguracionTransferencium IdconfiguracionTransferenciaNavigation { get; set; } = null!;
        public virtual ICollection<ItemConfiguracionEntradaSalidum> ItemConfiguracionEntradaSalida { get; set; }
    }
}

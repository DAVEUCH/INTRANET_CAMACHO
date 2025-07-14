using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class AsistenteNoDomiciliado
    {
        public int Pkid { get; set; }
        public bool AplicacionArticulo76 { get; set; }
        public int IdlibroElectronicoTabla25 { get; set; }
        public int IdlibroElectronicoTabla31 { get; set; }
        public int IdlibroElectronicoTabla32 { get; set; }
        public int IdlibroElectronicoTabla33 { get; set; }
        public int Idcp { get; set; }

        public virtual Cp IdcpNavigation { get; set; } = null!;
        public virtual LibroElectronicoTabla25 IdlibroElectronicoTabla25Navigation { get; set; } = null!;
        public virtual LibroElectronicoTabla31 IdlibroElectronicoTabla31Navigation { get; set; } = null!;
        public virtual LibroElectronicoTabla32 IdlibroElectronicoTabla32Navigation { get; set; } = null!;
        public virtual LibroElectronicoTabla33 IdlibroElectronicoTabla33Navigation { get; set; } = null!;
    }
}

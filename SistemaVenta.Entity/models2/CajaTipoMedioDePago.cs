using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class CajaTipoMedioDePago
    {
        public int Pkid { get; set; }
        public int Idcaja { get; set; }
        public int IdtipoMedioDePago { get; set; }
        public bool Emision { get; set; }
        public bool Recepcion { get; set; }
        public bool Numeracion { get; set; }

        public virtual Caja IdcajaNavigation { get; set; } = null!;
        public virtual TipoMedioDePago IdtipoMedioDePagoNavigation { get; set; } = null!;
    }
}

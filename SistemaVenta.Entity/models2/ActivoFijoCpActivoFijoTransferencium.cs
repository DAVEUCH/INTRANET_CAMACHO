using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ActivoFijoCpActivoFijoTransferencium
    {
        public int Pkid { get; set; }
        public int IdcpActivoFijoSalida { get; set; }
        public int IdcpActivoFijoEntrada { get; set; }
        public string NumDocOrigen { get; set; } = null!;
        public string EstadoRecepcion { get; set; } = null!;
        public string Idvehiculo { get; set; } = null!;
        public bool RequiereTransportista { get; set; }

        public virtual CpInventario IdcpActivoFijoEntradaNavigation { get; set; } = null!;
        public virtual CpInventario IdcpActivoFijoSalidaNavigation { get; set; } = null!;
        public virtual Cp Pk { get; set; } = null!;
    }
}

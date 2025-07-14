using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ActivoFijoCpActivoFijoSalidum
    {
        public int Pkid { get; set; }
        public int IdcpInventario { get; set; }
        public string EstadoFacturacion { get; set; } = null!;
        public string EstadoDevolucion { get; set; } = null!;
        public string NumeroOrdenCompra { get; set; } = null!;
        public string DireccionEntrega { get; set; } = null!;
        public int Idvehiculo { get; set; }
        public bool RequiereTransportista { get; set; }
        public string EstadoEntregaDevolucion { get; set; } = null!;
        public int Idvehiculo2 { get; set; }
        public string DireccionTransportista { get; set; } = null!;
        public string DireccionTransportista2 { get; set; } = null!;

        public virtual CpInventario IdcpInventarioNavigation { get; set; } = null!;
        public virtual Cp Pk { get; set; } = null!;
    }
}

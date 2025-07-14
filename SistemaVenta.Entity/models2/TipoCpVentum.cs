using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TipoCpVentum
    {
        public int Pkid { get; set; }
        public int Idalmacen { get; set; }
        public int IdtipoDocIdentidad { get; set; }
        public bool RequiereCliente { get; set; }
        public bool RestringirAlmacen { get; set; }
        public decimal MontoMinimo { get; set; }
        public bool FueraDeRuta { get; set; }
        public bool AplicaDistribucion { get; set; }
        public bool AplicaRedondeo { get; set; }
        public int NumeroPrecisionRedondeo { get; set; }

        public virtual TipoDocIdentidad IdtipoDocIdentidadNavigation { get; set; } = null!;
        public virtual TipoCp Pk { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ECpDistribucion
    {
        public int Id { get; set; }
        public int IdfuerzaVentas { get; set; }
        public int IdzonaVenta { get; set; }
        public int IdzonaReparto { get; set; }
        public bool FueraDeRuta { get; set; }
        public int IdgrupoVentas { get; set; }
    }
}

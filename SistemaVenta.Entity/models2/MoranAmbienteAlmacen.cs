using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class MoranAmbienteAlmacen
    {
        public MoranAmbienteAlmacen()
        {
            MoranUbicacionProductos = new HashSet<MoranUbicacionProducto>();
        }

        public int Pkid { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int Orden { get; set; }
        public int Idalmacen { get; set; }

        public virtual ICollection<MoranUbicacionProducto> MoranUbicacionProductos { get; set; }
    }
}

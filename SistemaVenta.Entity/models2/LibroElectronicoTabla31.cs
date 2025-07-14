using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class LibroElectronicoTabla31
    {
        public LibroElectronicoTabla31()
        {
            AsistenteNoDomiciliados = new HashSet<AsistenteNoDomiciliado>();
        }

        public int Pkid { get; set; }
        public string Descripcion { get; set; } = null!;
        public string Codigo { get; set; } = null!;

        public virtual ICollection<AsistenteNoDomiciliado> AsistenteNoDomiciliados { get; set; }
    }
}

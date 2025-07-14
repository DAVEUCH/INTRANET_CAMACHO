using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Distrito
    {
        public Distrito()
        {
            Direccions = new HashSet<Direccion>();
        }

        public int Pkid { get; set; }
        public int Idprovincia { get; set; }
        public string Descripcion { get; set; } = null!;
        public string Ubigeo { get; set; } = null!;

        public virtual Provincium IdprovinciaNavigation { get; set; } = null!;
        public virtual ICollection<Direccion> Direccions { get; set; }
    }
}

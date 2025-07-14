using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Provincium
    {
        public Provincium()
        {
            Direccions = new HashSet<Direccion>();
            Distritos = new HashSet<Distrito>();
        }

        public int Pkid { get; set; }
        public int Iddepartamento { get; set; }
        public string Descripcion { get; set; } = null!;
        public string Ubigeo { get; set; } = null!;

        public virtual Departamento IddepartamentoNavigation { get; set; } = null!;
        public virtual ICollection<Direccion> Direccions { get; set; }
        public virtual ICollection<Distrito> Distritos { get; set; }
    }
}

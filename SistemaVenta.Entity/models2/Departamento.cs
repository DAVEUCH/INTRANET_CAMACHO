using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Departamento
    {
        public Departamento()
        {
            Direccions = new HashSet<Direccion>();
            Provincia = new HashSet<Provincium>();
        }

        public int Pkid { get; set; }
        public string Descripcion { get; set; } = null!;
        public string Ubigeo { get; set; } = null!;

        public virtual ICollection<Direccion> Direccions { get; set; }
        public virtual ICollection<Provincium> Provincia { get; set; }
    }
}

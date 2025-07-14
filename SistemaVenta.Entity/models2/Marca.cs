using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Marca
    {
        public Marca()
        {
            MarcaAuspiciadors = new HashSet<MarcaAuspiciador>();
            Productos = new HashSet<Producto>();
        }

        public int Pkid { get; set; }
        public string Descripcion { get; set; } = null!;
        public bool? Activo { get; set; }
        public string Codigo { get; set; } = null!;

        public virtual ICollection<MarcaAuspiciador> MarcaAuspiciadors { get; set; }
        public virtual ICollection<Producto> Productos { get; set; }
    }
}

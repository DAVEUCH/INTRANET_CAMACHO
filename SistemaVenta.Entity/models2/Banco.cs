using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Banco
    {
        public Banco()
        {
            Cajas = new HashSet<Caja>();
            MedioDePagos = new HashSet<MedioDePago>();
        }

        public int Pkid { get; set; }
        public string Nombre { get; set; } = null!;
        public string Codigo { get; set; } = null!;

        public virtual ICollection<Caja> Cajas { get; set; }
        public virtual ICollection<MedioDePago> MedioDePagos { get; set; }
    }
}

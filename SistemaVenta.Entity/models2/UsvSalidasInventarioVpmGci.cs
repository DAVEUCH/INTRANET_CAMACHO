using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvSalidasInventarioVpmGci
    {
        public int Pkid { get; set; }
        public DateTime Fecha { get; set; }
        public int Idpersona { get; set; }
        public int IdtipoCp { get; set; }
        public int Idproducto { get; set; }
    }
}

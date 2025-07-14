using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VUnidadListaPreciosFactorMayor
    {
        public int IdcategoriaCliente { get; set; }
        public int IditemListaPreccios { get; set; }
        public int Idproducto { get; set; }
        public int? Factor { get; set; }
    }
}

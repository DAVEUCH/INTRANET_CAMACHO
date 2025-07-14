using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VcorregirUnidad
    {
        public int Idproducto { get; set; }
        public int IdunidadBorrar { get; set; }
        public int IdunidadBase { get; set; }
        public int IdunidadReferencia { get; set; }
        public int IdunidadCompra { get; set; }
    }
}

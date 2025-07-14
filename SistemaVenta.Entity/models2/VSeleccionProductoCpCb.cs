using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VSeleccionProductoCpCb
    {
        public int Idalmacen { get; set; }
        public int IdlistaPrecios { get; set; }
        public int IditemListaPrecios { get; set; }
        public int IdunidadItemListaPrecios { get; set; }
        public int Idunidad { get; set; }
        public string CodigoBarras { get; set; } = null!;
        public int Factor { get; set; }
        public bool Bonificacion { get; set; }
        public int Idproducto { get; set; }
    }
}

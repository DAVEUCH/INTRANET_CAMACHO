using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvItemListaPreciosGoldeagle
    {
        public int IdlistaPrecios { get; set; }
        public int Idproducto { get; set; }
        public string Descripcion { get; set; } = null!;
        public int EscalaId { get; set; }
        public decimal MargenNegociacionPorcentualA { get; set; }
        public decimal MargenNegociacionPorcentualB { get; set; }
    }
}

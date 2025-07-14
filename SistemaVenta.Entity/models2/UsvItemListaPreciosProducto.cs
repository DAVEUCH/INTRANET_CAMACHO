using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvItemListaPreciosProducto
    {
        public int IdlistaPrecios { get; set; }
        public int Idproducto { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int Factor { get; set; }
        public string UnidMed { get; set; } = null!;
        public int EscalaId { get; set; }
        public decimal? PrecioIncImpto { get; set; }
        public decimal? PrecioIncImptoSoles { get; set; }
        public decimal? PecioAnte { get; set; }
        public decimal MargenNegociacionPorcentualA { get; set; }
        public decimal MargenNegociacionPorcentualB { get; set; }
    }
}

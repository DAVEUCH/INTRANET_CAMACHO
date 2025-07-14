using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvItemListaPreciosVigenteLppdv07ActualizarPrecio
    {
        public int ItemListaPreciosId { get; set; }
        public int IdlistaPrecios { get; set; }
        public int Idproducto { get; set; }
        public string Codigo { get; set; } = null!;
        public int UnidadItemListaPreciosId { get; set; }
        public int Idunidad { get; set; }
        public int Factor { get; set; }
        public int EscalaId { get; set; }
        public decimal Precio { get; set; }
        public decimal PrecioIncImpto { get; set; }
        public decimal MargenNegociacionPorcentualA { get; set; }
        public decimal MargenNegociacionPorcentualB { get; set; }
    }
}

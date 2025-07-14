using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptInformacionListaPrecio2222
    {
        public string ListaPrecioDescripcion { get; set; } = null!;
        public string ListaPrecioMonedaSimbolo { get; set; } = null!;
        public string ListaPrecioProductoCodigo { get; set; } = null!;
        public string ListaPrecioProductoDescripcion { get; set; } = null!;
        public string? ListaPrecioProductoEscalaPrecios { get; set; }
        public int ListaPrecioProductoId { get; set; }
        public int ListaPrecioId { get; set; }
        public string ListaPrecioProductoClaseProductoCodigo { get; set; } = null!;
        public string ListaPrecioProductoClaseProductoDescripcion { get; set; } = null!;
        public string? ProveedorCodigo { get; set; }
        public string? ProveedorNombre { get; set; }
        public string Marca { get; set; } = null!;
        public int ListaPrecioProductoMarcaId { get; set; }
        public int? ListaPrecioProductoProveedorId { get; set; }
        public int ListaPrecioProductoClaseProdServId { get; set; }
    }
}

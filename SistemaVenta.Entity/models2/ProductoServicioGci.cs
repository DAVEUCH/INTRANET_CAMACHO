using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ProductoServicioGci
    {
        public int Pkid { get; set; }
        public int IdclaseProductoServicio { get; set; }
        public int IdunidadBase { get; set; }
        public int IdunidadReferencia { get; set; }
        public string Codigo { get; set; } = null!;
        public string CodigoAfinidad { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public bool Activo { get; set; }
        public string CodigoAfinidad2 { get; set; } = null!;
        public bool ArticuloVenta { get; set; }
        public bool ArticuloCompra { get; set; }
        public bool ArticuloInventario { get; set; }
        public int IdtipoProductoServicio { get; set; }
        public string DescripcionResumida { get; set; } = null!;
        public bool Granel { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvComprasPlazaCodigoAplicacionOld
    {
        public int IdDocCompra { get; set; }
        public DateTime Fecha { get; set; }
        public int Idsucursal { get; set; }
        public string TipoCp { get; set; } = null!;
        public string Numerocp { get; set; } = null!;
        public int ProveedorId { get; set; }
        public string ProveedorNombre { get; set; } = null!;
        public int? MarcaId { get; set; }
        public string? MarcaDescripcion { get; set; }
        public int Idproducto { get; set; }
        public string CodigoProducto { get; set; } = null!;
        public string DescripcionProducto { get; set; } = null!;
        public string? AplicaProducto { get; set; }
        public decimal StockGrupo { get; set; }
        public string? Unidad { get; set; }
        public decimal Cantidad { get; set; }
        public decimal ValorUnitario { get; set; }
        public string Observacion { get; set; } = null!;
    }
}

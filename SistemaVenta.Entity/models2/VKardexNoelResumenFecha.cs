using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VKardexNoelResumenFecha
    {
        public int Idsucursal { get; set; }
        public int Idalmacen { get; set; }
        public int Idproducto { get; set; }
        public int? Entrada { get; set; }
        public int? Salida { get; set; }
        public string Codigo { get; set; } = null!;
        public string Producto { get; set; } = null!;
        public string Marca { get; set; } = null!;
        public string CodigoClase { get; set; } = null!;
        public string UnidadRef { get; set; } = null!;
        public int FactorRef { get; set; }
        public string UnidadBase { get; set; } = null!;
        public int FactorBase { get; set; }
        public DateTime Fecha { get; set; }
        public string ClaseProducto { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VKardex
    {
        public int Idsucursal { get; set; }
        public int Idalmacen { get; set; }
        public int Idcp { get; set; }
        public int IdtipoCp { get; set; }
        public int Idproducto { get; set; }
        public string NumCp { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public DateTime FechaEmision { get; set; }
        public string TipoCp { get; set; } = null!;
        public int? EntradaUbase { get; set; }
        public int? SalidaUbase { get; set; }
        public int Orden { get; set; }
        public string OrigenDestinoNombre { get; set; } = null!;
        public string CodigoAlmacen { get; set; } = null!;
        public string Almacen { get; set; } = null!;
        public string Codigo { get; set; } = null!;
        public string Producto { get; set; } = null!;
        public string Marca { get; set; } = null!;
        public string CodigoClase { get; set; } = null!;
        public string ClaseProducto { get; set; } = null!;
    }
}

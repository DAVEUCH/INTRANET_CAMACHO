using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptListaTomaInventario
    {
        public string NumeroLista { get; set; } = null!;
        public string Observacion { get; set; } = null!;
        public string CodigoLinea { get; set; } = null!;
        public string Linea { get; set; } = null!;
        public string CodigoProducto { get; set; } = null!;
        public string Producto { get; set; } = null!;
        public string Marca { get; set; } = null!;
        public string UnidadConteo { get; set; } = null!;
        public string CodigoResponsableConteo { get; set; } = null!;
        public string NombreResponsableConteo { get; set; } = null!;
        public string CodigoResponsableReconteo { get; set; } = null!;
        public string NombreResponsableReconteo { get; set; } = null!;
        public int CantidadContada { get; set; }
        public int CantidadRecontada { get; set; }
        public int Idsucursal { get; set; }
        public DateTime Fecha { get; set; }
        public string Sucursal { get; set; } = null!;
        public int Factor { get; set; }
        public int Idalmacen { get; set; }
        public string AlmacenCodigo { get; set; } = null!;
        public string AlmacenNombre { get; set; } = null!;
    }
}

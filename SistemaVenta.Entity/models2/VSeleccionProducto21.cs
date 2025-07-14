using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VSeleccionProducto21
    {
        public int IdlistaPrecios { get; set; }
        public int Idproducto { get; set; }
        public string Codigo { get; set; } = null!;
        public int Idalmacen { get; set; }
        public string Descripcion { get; set; } = null!;
        public int IditemListaPrecios { get; set; }
        public int Idsucursal { get; set; }
        public string Uref { get; set; } = null!;
        public int FactorUref { get; set; }
        public bool Bonificacion { get; set; }
        public bool Activo { get; set; }
        public bool Agrupacion { get; set; }
        public bool GestionaStock { get; set; }
        public string CodigoFabrica { get; set; } = null!;
        public bool Desactivado { get; set; }
        public bool GestionaLoteFabricacion { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VSeleccionProducto4
    {
        public string Codigo { get; set; } = null!;
        public int Idalmacen { get; set; }
        public string Descripcion { get; set; } = null!;
        public int Idsucursal { get; set; }
        public string Uref { get; set; } = null!;
        public int FactorUref { get; set; }
        public bool Activo { get; set; }
        public decimal CostoPromedioSoles { get; set; }
        public decimal CostoUltimaCompraSoles { get; set; }
        public decimal CostoReferenciaSoles { get; set; }
        public decimal CostoParaleloSoles { get; set; }
        public int Idproducto { get; set; }
    }
}

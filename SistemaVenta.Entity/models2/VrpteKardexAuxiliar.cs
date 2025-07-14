using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteKardexAuxiliar
    {
        public int Idalmacen { get; set; }
        public int Idsucursal { get; set; }
        public int IdclaseProductoServicio { get; set; }
        public int Idmarca { get; set; }
        public int? Idproveedor { get; set; }
        public int Idproducto { get; set; }
        public DateTime Fecha { get; set; }
        public int CantidadFisico { get; set; }
    }
}

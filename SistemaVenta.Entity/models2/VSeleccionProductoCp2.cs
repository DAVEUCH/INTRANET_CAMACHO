using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VSeleccionProductoCp2
    {
        public int Idalmacen { get; set; }
        public int Idsucursal { get; set; }
        public int Idproducto { get; set; }
        public int? Idproveedor { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Uref { get; set; } = null!;
        public string? Stock { get; set; }
        public string? StockDisponible { get; set; }
        public int UrefFactor { get; set; }
        public bool Consignacion { get; set; }
        public bool Agrupacion { get; set; }
        public bool GestionaStock { get; set; }
        public string CodigoFabrica { get; set; } = null!;
        public string CodigoAfinidad { get; set; } = null!;
        public bool GestionaLoteFabricacion { get; set; }
    }
}

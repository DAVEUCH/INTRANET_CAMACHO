using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VSeleccionProductoCp3
    {
        public string Idalmacen { get; set; } = null!;
        public int? Idproveedor { get; set; }
        public int Idproducto { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Uref { get; set; } = null!;
        public int UrefFactor { get; set; }
        public string Stock { get; set; } = null!;
        public string StockDisponible { get; set; } = null!;
        public bool Consignacion { get; set; }
        public bool ArticuloInventario { get; set; }
        public int IdlistaPrecios { get; set; }
        public int IditemListaPrecios { get; set; }
        public bool Bonificacion { get; set; }
        public string CodigoFabrica { get; set; } = null!;
        public bool Desactivado { get; set; }
        public string CodigoAfinidad { get; set; } = null!;
        public bool GestionaLoteFabricacion { get; set; }
    }
}

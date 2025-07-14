using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VSeleccionProductoCp
    {
        public int IdlistaPrecios { get; set; }
        public int IditemListaPrecios { get; set; }
        public int Idsucursal { get; set; }
        public int Idalmacen { get; set; }
        public int Idproducto { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Uref { get; set; } = null!;
        public int FactorUref { get; set; }
        public int Stock { get; set; }
        public int StockDisponible { get; set; }
        public int StockFisico { get; set; }
        public int StockContable { get; set; }
        public int StockPorRecibir { get; set; }
        public int StockPorEntregar { get; set; }
        public bool Bonificacion { get; set; }
        public bool Activo { get; set; }
        public string CodigoFabrica { get; set; } = null!;
        public bool GestionaLoteFabricacion { get; set; }
    }
}

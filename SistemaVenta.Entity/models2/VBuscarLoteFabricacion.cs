using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VBuscarLoteFabricacion
    {
        public int Id { get; set; }
        public string Numero { get; set; } = null!;
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public DateTime FechaVencimiento { get; set; }
        public int StockFisico { get; set; }
        public int StockPorEntregar { get; set; }
        public int? StockDisponible { get; set; }
        public int Idalmacen { get; set; }
        public int Idproducto { get; set; }
        public int IdloteFabricacion { get; set; }
        public int StockPorRecibir { get; set; }
        public bool Activo { get; set; }
    }
}

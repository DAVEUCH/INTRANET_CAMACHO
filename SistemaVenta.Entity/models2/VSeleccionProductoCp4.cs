using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VSeleccionProductoCp4
    {
        public int Idsucursal { get; set; }
        public int Idalmacen { get; set; }
        public string Codigo { get; set; } = null!;
        public int Idproducto { get; set; }
        public string Descripcion { get; set; } = null!;
        public string Uref { get; set; } = null!;
        public int FactorUref { get; set; }
        public string? Stock { get; set; }
        public string? StockDisponible { get; set; }
        public int StockFisico { get; set; }
        public int StockContable { get; set; }
        public int StockPorRecibir { get; set; }
        public int StockPorEntregar { get; set; }
        public bool Activo { get; set; }
        public decimal CostoPromedioSoles { get; set; }
        public decimal CostoUltimaCompraSoles { get; set; }
        public decimal CostoReferenciaSoles { get; set; }
        public decimal CostoParaleloSoles { get; set; }
    }
}

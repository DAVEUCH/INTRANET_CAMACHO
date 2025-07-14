using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VComprasContabilidadNess
    {
        public DateTime Fecha { get; set; }
        public decimal CargoMonedaBase { get; set; }
        public decimal ComprasPlaza { get; set; }
        public decimal ComprasMayor { get; set; }
        public decimal ComprasRelacionadas { get; set; }
        public decimal ComprasImportacion { get; set; }
        public decimal GastoImportacion { get; set; }
        public decimal Gastos { get; set; }
        public string Descripcion { get; set; } = null!;
        public string Abreviacion { get; set; } = null!;
        public int IdtipoComprobantePago { get; set; }
        public string Tipocp { get; set; } = null!;
        public string Proveedor { get; set; } = null!;
        public bool Anulado { get; set; }
        public string Nombre { get; set; } = null!;
        public string Mes { get; set; } = null!;
        public string Año { get; set; } = null!;
    }
}

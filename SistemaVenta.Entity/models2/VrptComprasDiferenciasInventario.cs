using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptComprasDiferenciasInventario
    {
        public string TipoOperacion { get; set; } = null!;
        public DateTime OpFecha { get; set; }
        public string OpNumero { get; set; } = null!;
        public decimal OpTipoCambio { get; set; }
        public decimal? OpSoles { get; set; }
        public string? TipoOperacion2 { get; set; }
        public DateTime? Op2Fecha { get; set; }
        public string? Op2Numero { get; set; }
        public decimal? Op2TipoCambio { get; set; }
        public decimal? Op2Soles { get; set; }
        public decimal? Diferencia { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int Grupo { get; set; }
    }
}

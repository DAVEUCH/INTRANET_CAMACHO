using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvPedidoEstadosTotalRelaGuiayFact
    {
        public int Pkid { get; set; }
        public string NumPedido { get; set; } = null!;
        public DateTime FechaEmiPedido { get; set; }
        public string TipoCp { get; set; } = null!;
        public string CptoOperacion { get; set; } = null!;
        public string EstadoAprobacion { get; set; } = null!;
        public string? EstadoEntrega { get; set; }
        public string? EstadoFacturacion { get; set; }
        public int GrRelacion { get; set; }
        public int FvRelacion { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public decimal Cantidad { get; set; }
    }
}

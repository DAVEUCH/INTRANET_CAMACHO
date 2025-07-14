using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvPedidoDespahoaAgenciasTransporte
    {
        public string NombreEmpTransp { get; set; } = null!;
        public string? Departamento { get; set; }
        public string? Provincia { get; set; }
        public string? Distrito { get; set; }
        public int? IdclienteEntrega { get; set; }
        public string NumeroPedido { get; set; } = null!;
        public DateTime FechaPedido { get; set; }
        public string DireccionEntrega { get; set; } = null!;
        public string? DepartamentoEntrega { get; set; }
        public string? ProvinciaEntrega { get; set; }
        public string? DistritoEntrega { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class NessOrdenCompra
    {
        public string NumCp { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string? Proveedor { get; set; }
        public string Marca { get; set; } = null!;
        public string Codoriginal { get; set; } = null!;
        public string Codreferencial { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string? Aplicacion { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Valor { get; set; }
        public decimal Total { get; set; }
        public string Credito { get; set; } = null!;
        public string Responsable { get; set; } = null!;
        public DateTime? FechaEmbarque { get; set; }
        public DateTime? Fechacotizacion { get; set; }
        public bool Importacion { get; set; }
    }
}

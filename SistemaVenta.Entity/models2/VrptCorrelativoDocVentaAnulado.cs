using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptCorrelativoDocVentaAnulado
    {
        public string Serie { get; set; } = null!;
        public string NumCp { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; } = null!;
        public decimal Total { get; set; }
        public string MotivoAnulacion { get; set; } = null!;
        public string CodigoVendedor { get; set; } = null!;
        public string NombreVendedor { get; set; } = null!;
        public string Abreviacion { get; set; } = null!;
        public int Idsucursal { get; set; }
    }
}

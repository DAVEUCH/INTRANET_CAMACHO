using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VAlmapoKardexXProducto
    {
        public string Sucursal { get; set; } = null!;
        public string Tcp { get; set; } = null!;
        public string IdtipoCp { get; set; } = null!;
        public string TipoCp { get; set; } = null!;
        public string NumCp { get; set; } = null!;
        public DateTime FechaEmision { get; set; }
        public string Cliente { get; set; } = null!;
        public decimal Cantidad { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string CodResp { get; set; } = null!;
        public string Responsable { get; set; } = null!;
        public bool Anulado { get; set; }
        public decimal ValorUnitario { get; set; }
    }
}

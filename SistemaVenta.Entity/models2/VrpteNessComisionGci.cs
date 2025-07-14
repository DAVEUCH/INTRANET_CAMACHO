using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteNessComisionGci
    {
        public string CodTipCp { get; set; } = null!;
        public string TipoCp { get; set; } = null!;
        public int SucursalId { get; set; }
        public int VendedorId { get; set; }
        public string NumCp { get; set; } = null!;
        public string Codigo { get; set; } = null!;
        public string Vendedor { get; set; } = null!;
        public decimal? ValorVentaDolares { get; set; }
        public decimal? ComisionNeto { get; set; }
        public DateTime Fecha { get; set; }
        public string? CodigoRelacionado { get; set; }
        public string? DescripcionRela { get; set; }
        public string Cliente { get; set; } = null!;
    }
}

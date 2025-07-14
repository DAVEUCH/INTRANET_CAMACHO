using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class FuerzaVenta
    {
        public FuerzaVenta()
        {
            CpDistribucions = new HashSet<CpDistribucion>();
            FuerzaVentasZonas = new HashSet<FuerzaVentasZona>();
            GrupoVenta = new HashSet<GrupoVenta>();
            ItemFuerzaVentasVendedors = new HashSet<ItemFuerzaVentasVendedor>();
            LineaCreditoPorFuerzaVenta = new HashSet<LineaCreditoPorFuerzaVenta>();
        }

        public int Pkid { get; set; }
        public int Iddivision { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Observacion { get; set; } = null!;

        public virtual ICollection<CpDistribucion> CpDistribucions { get; set; }
        public virtual ICollection<FuerzaVentasZona> FuerzaVentasZonas { get; set; }
        public virtual ICollection<GrupoVenta> GrupoVenta { get; set; }
        public virtual ICollection<ItemFuerzaVentasVendedor> ItemFuerzaVentasVendedors { get; set; }
        public virtual ICollection<LineaCreditoPorFuerzaVenta> LineaCreditoPorFuerzaVenta { get; set; }
    }
}

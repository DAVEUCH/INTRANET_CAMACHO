using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Dua
    {
        public int Pkid { get; set; }
        public int IdimpuestoDua { get; set; }
        public int Idincoterm { get; set; }
        public int Idalmacen { get; set; }
        public string EstadoImportacion { get; set; } = null!;
        public decimal TotalIncoterm { get; set; }
        public decimal TotalFlete { get; set; }
        public decimal TotalSeguro { get; set; }
        public decimal TotalCif { get; set; }
        public decimal TotalAjuste { get; set; }
        public decimal TotalAduana { get; set; }
        public decimal TotalArancel { get; set; }
        public decimal TotalFob { get; set; }
        public decimal PorcentajePercepcion { get; set; }
        public decimal TotalServicioDespacho { get; set; }
        public decimal TotalPercepcion { get; set; }
        public string SerieDependenciaAduanera { get; set; } = null!;

        public virtual Almacen IdalmacenNavigation { get; set; } = null!;
        public virtual Impuesto IdimpuestoDuaNavigation { get; set; } = null!;
        public virtual Incoterm IdincotermNavigation { get; set; } = null!;
        public virtual Cp Pk { get; set; } = null!;
    }
}

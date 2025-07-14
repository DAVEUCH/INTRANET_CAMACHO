using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class OrdenAnulacion
    {
        public OrdenAnulacion()
        {
            ItemOrdenAnulacionConsolidadoCargas = new HashSet<ItemOrdenAnulacionConsolidadoCarga>();
            ItemOrdenAnulacions = new HashSet<ItemOrdenAnulacion>();
        }

        public int Pkid { get; set; }
        public int IdconsolidadoCarga { get; set; }
        public int IdcpVenta { get; set; }
        public int Idresponsable { get; set; }
        public int IdmotivoAnulacion { get; set; }
        public DateTime Fecha { get; set; }
        public bool AnulacionTotal { get; set; }
        public string EstadoEjecucion { get; set; } = null!;
        public int? IdnotaCredito { get; set; }
        public int Idcliente { get; set; }
        public int IdtipoOrdenAnulacion { get; set; }
        public int Idalmacen { get; set; }
        public string NumCp { get; set; } = null!;
        public decimal Total { get; set; }

        public virtual ConsolidadoCarga IdconsolidadoCargaNavigation { get; set; } = null!;
        public virtual CpVentum IdcpVentaNavigation { get; set; } = null!;
        public virtual Persona IdresponsableNavigation { get; set; } = null!;
        public virtual ICollection<ItemOrdenAnulacionConsolidadoCarga> ItemOrdenAnulacionConsolidadoCargas { get; set; }
        public virtual ICollection<ItemOrdenAnulacion> ItemOrdenAnulacions { get; set; }
    }
}

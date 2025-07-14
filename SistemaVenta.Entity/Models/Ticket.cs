using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenta.Entity.Models
{
    public partial class Ticket
    {
        public int IdTicket { get; set; }
        public string? Titulo { get; set; }
        public string? Descripcion { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public int? IdUsuario { get; set; }
        public int? IdAsignado { get; set; }
        public int? IdTipoSop { get; set; }
        public int? IdCategoriaSop { get; set; }
        public int? IdPrioridad { get; set; }
        public int? IdEstadoTiket { get; set; }
        public int? IdArea { get; set; }
        public int? IdEmpresa { get; set; }
        public string? ArchivoHash { get; set; }

        public virtual Area? IdAreaNavigation { get; set; }
        public virtual CategoriaSop? IdCategoriaSopNavigation { get; set; }
        public virtual EstadoTiket? IdEstadoTiketNavigation { get; set; }
        public virtual TipoSop? IdTipoSopNavigation { get; set; }
        public virtual Usuario? IdUsuarioNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            FormInterIngres = new HashSet<FormInterIngre>();
            //FormInterSals = new HashSet<FormInterSal>();
            Venta = new HashSet<Venta>();
            SubCategoriaSops = new HashSet<SubCategoriaSop>();
            Tickets = new HashSet<Ticket>();
            Salida = new HashSet<Salida>();
        }

        public int IdUsuario { get; set; }
        public string? Nombre { get; set; }
        public string? Correo { get; set; }
        public string? Telefono { get; set; }
        public int? IdRol { get; set; }
        public int? IdArea { get; set; }
        public int? IdEmpresa { get; set; }
        public string? UrlFoto { get; set; }
        public string? NombreFoto { get; set; }
        public int? Kind { get; set; }
        public string? Clave { get; set; }
        public bool? EsActivo { get; set; }
        public DateTime? FechaRegistro { get; set; }

        public virtual Area? IdAreaNavigation { get; set; }
        public virtual Empresa? IdEmpresaNavigation { get; set; }
        public virtual Rol? IdRolNavigation { get; set; }
        public virtual ICollection<FormInterIngre> FormInterIngres { get; set; }
        //public virtual ICollection<FormInterSal> FormInterSals { get; set; }
        public virtual ICollection<Venta> Venta { get; set; }
        public virtual ICollection<Salida> Salida { get; set; }
        public virtual ICollection<SubCategoriaSop> SubCategoriaSops { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            FormInterIngres = new HashSet<FormInterIngre>();
            Venta = new HashSet<Venta>();
            Salida = new HashSet<Salida>();
        }

        public int IdUsuario { get; set; }
        public string? Nombre { get; set; }
        public string? Correo { get; set; }
        public string? Telefono { get; set; }
        public int? IdRol { get; set; }
        public string? UrlFoto { get; set; }
        public string? NombreFoto { get; set; }
        public string? Clave { get; set; }
        public bool? EsActivo { get; set; }
        public DateTime? FechaRegistro { get; set; }

        public virtual Rol? IdRolNavigation { get; set; }
        public virtual ICollection<FormInterIngre> FormInterIngres { get; set; }
        public virtual ICollection<Venta> Venta { get; set; }
        public virtual ICollection<Salida> Salida { get; set; }
    }
}

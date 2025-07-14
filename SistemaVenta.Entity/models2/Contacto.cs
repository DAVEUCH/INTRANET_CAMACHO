using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Contacto
    {
        public string Pkid { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Cargo { get; set; } = null!;
        /// <summary>
        /// (&apos;&apos;)
        /// </summary>
        public string Telefono1 { get; set; } = null!;
        /// <summary>
        /// (&apos;&apos;)
        /// </summary>
        public string Telefono2 { get; set; } = null!;
        /// <summary>
        /// (&apos;&apos;)
        /// </summary>
        public string Email { get; set; } = null!;
        /// <summary>
        /// (&apos;&apos;)
        /// </summary>
        public string HorarioAtencion { get; set; } = null!;
        public int Idpersona { get; set; }
        public DateTime FechaAniversario { get; set; }
        public DateTime FechaCumpleaños { get; set; }
        public string? AreaTrabajo { get; set; }
        public string? ContactoArea { get; set; }
        public string? Celular { get; set; }
        public bool? Anulado { get; set; }

        public virtual Persona IdpersonaNavigation { get; set; } = null!;
    }
}

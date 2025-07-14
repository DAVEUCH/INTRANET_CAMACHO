using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Comando2
    {
        public string Pkid { get; set; } = null!;
        public string IdtipoAsociado { get; set; } = null!;
        public string IdgrupoComandos { get; set; } = null!;
        public string IdactividadAsociada { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string TipoComando { get; set; } = null!;
        public string PrefijoNombreActividad { get; set; } = null!;
        public bool RequiereVistaActiva { get; set; }
        public bool RequiereItemSeleccionado { get; set; }
        public string Imagen { get; set; } = null!;
        public int Posicion { get; set; }

        public virtual Actividad IdactividadAsociadaNavigation { get; set; } = null!;
        public virtual GrupoComando IdgrupoComandosNavigation { get; set; } = null!;
        public virtual Clasificador IdtipoAsociadoNavigation { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Comando
    {
        public string Pkid { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int IndiceIcono { get; set; }
        public string IdtipoAsociado { get; set; } = null!;
        public string IdtipoReferencia { get; set; } = null!;
        public string IdgrupoComandos { get; set; } = null!;
        public string OperacionReferencia { get; set; } = null!;
        public bool ComandoDeConsola { get; set; }
        public bool EsOperacion { get; set; }
        public bool RequiereVistaActiva { get; set; }
        public bool RequiereItemSeleccionado { get; set; }
        public string NombreOperacion { get; set; } = null!;
        public string Imagen { get; set; } = null!;
        public int Posicion { get; set; }
        public bool? Heredable { get; set; }

        public virtual GrupoComando IdgrupoComandosNavigation { get; set; } = null!;
    }
}

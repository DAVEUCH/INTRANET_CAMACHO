using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptInformacionDireccionOrigenDestino
    {
        public string OrigenDestinoDireccionDescripcion { get; set; } = null!;
        public string OrigenDestinoDistritoNombre { get; set; } = null!;
        public string OrigenDestinoProvinciaNombre { get; set; } = null!;
        public string OrigenDestinoDepartamentoNombre { get; set; } = null!;
        public string OrigenDestinoZonaCodigo { get; set; } = null!;
        public string OrigenDestinoZonaDescripcion { get; set; } = null!;
        public bool OrigenDestinoDireccionPrincipal { get; set; }
        public int OrigenDestinoDistritoId { get; set; }
        public int OrigenDestinoProvinciaId { get; set; }
        public int OrigenDestinoDepartamentoId { get; set; }
        public int OrigenDestinoZonaId { get; set; }
        public int OrigenDestinoId { get; set; }
        public int OrigenDestinoDireccionId { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ConversionUnidad
    {
        public int Pkid { get; set; }
        public int IdunidadOrigen { get; set; }
        public int IdunidadDestino { get; set; }
        public decimal Factor { get; set; }
        public string Descripcion { get; set; } = null!;

        public virtual UnidadMedidum IdunidadDestinoNavigation { get; set; } = null!;
        public virtual UnidadMedidum IdunidadOrigenNavigation { get; set; } = null!;
    }
}

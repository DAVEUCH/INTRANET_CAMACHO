using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EConversionUnidad
    {
        public int Id { get; set; }
        public decimal Factor { get; set; }
        public int IdunidadOrigen { get; set; }
        public int IdunidadDestino { get; set; }
        public string Descripcion { get; set; } = null!;
    }
}

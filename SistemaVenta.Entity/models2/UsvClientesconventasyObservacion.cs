using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvClientesconventasyObservacion
    {
        public int Idpersona { get; set; }
        public int? VendedorId { get; set; }
        public int? Conprotesto { get; set; }
        public int? Condeudavigen { get; set; }
        public int? Factpendcanje { get; set; }
        public int? Letrapendacept { get; set; }
        public DateTime? Ultfechaventa { get; set; }
    }
}

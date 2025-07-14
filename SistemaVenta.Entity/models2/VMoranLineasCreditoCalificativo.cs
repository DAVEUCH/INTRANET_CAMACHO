using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VMoranLineasCreditoCalificativo
    {
        public string FuerzaVentas { get; set; } = null!;
        public decimal LineaTotal { get; set; }
        public decimal LineaSaldo { get; set; }
        public string LineaModalidad { get; set; } = null!;
        public int DiasGracia { get; set; }
        public int MaxVencidas { get; set; }
        public string? Calificativos { get; set; }
        public int LineaDiasCredito { get; set; }
        public int Pkid { get; set; }
        public int Idcliente { get; set; }
        public int IdfuerzaVentas { get; set; }
        public int Idmoneda { get; set; }
    }
}
